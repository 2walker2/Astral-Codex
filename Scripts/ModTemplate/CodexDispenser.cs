using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;
using System.Collections;
using UnityEngine.UIElements;
using NewHorizons.OtherMods;
using UnityEngine.Playables;
using UnityEngine.InputSystem;
using System;

namespace AstralCodex
{
    internal class CodexDispenser : MonoBehaviour
    {
        const string AnimatorState = "DispenseCodec";

        bool active = false;
        bool startedScalingCore = false;
        bool coreScaled = false;
        bool animationStarted = false;
        bool complete = false;
        bool startedDispensing = false;

        //Timing information
        float totalDuration = 57.5f; //68; //Total duration of the animation
        float sinkDuration = 5; //How long it takes the probe to sink into the dispenser
        float probeRotationAcceleration = 10; //How fast the probe's rotation speed increases
        float probeRotationMaxSpeed = 150; //How fast the probe rotates once it's inside the dispenser

        float coreMaxScale = 1;
        float coreScaleSpeed = 0.5f;

        float minRemainingTime = 90; //The maximum time that will be added to the end of the time loop when the player starts getting the Codec

        SurveyorProbe probe;
        Light[] probeLights;
        ProbeLauncher probeLauncher;
        ProbePromptReceiver probePrompt;
        Animator animator;
        GameObject addendumDialogueTrigger;
        NomaiComputer coreComputer;
        NomaiTranslator translator;
        Transform coreTransform;
        OWAudioSource chimeMusic;
        ParticleSystem addendumParticles;
        ProbeParticles probeParticles;
        GameObject shatterEffect;
        MeshRenderer baseModelRenderer;
        int wireMaterialIndex = 5;

        Wire sunWire;
        Wire populationWire;
        Wire technologyWire;

        void Start()
        {
            //Initialize callback
            Locator.GetProbe().GetAnchor().OnAnchorToSurface += ProbeAnchored;

            //Component references
            probe = Locator.GetProbe();
            probeLights = probe.transform.GetComponentsInChildren<Light>();
            probeLauncher = Locator.GetPlayerCamera().GetComponentInChildren<ProbeLauncher>();
            probePrompt = GetComponentInChildren<ProbePromptReceiver>();
            animator = transform.parent.GetComponentInChildren<Animator>();
            addendumDialogueTrigger = SearchUtilities.Find("CodecAddendumDialogue").gameObject;
            coreComputer = SearchUtilities.Find("CodexCoreComputer").GetComponent<NomaiComputer>();
            translator = SearchUtilities.Find("Player_Body/PlayerCamera/NomaiTranslatorProp").GetComponent<NomaiTranslator>();
            coreTransform = transform.GetChild(0);
            chimeMusic = SearchUtilities.Find("Station/Audio/Music").GetComponent<OWAudioSource>();
            addendumParticles = SearchUtilities.Find("Station/CodecDispenser/AddendumParticles").GetComponent<ParticleSystem>();
            probeParticles = probe.GetComponentInChildren<ProbeParticles>();
            baseModelRenderer = SearchUtilities.Find("Station/CodecDispenser/Model/Base").GetComponent<MeshRenderer>();
            shatterEffect = SearchUtilities.Find("Station/CodecDispenser/Shatter Effect");

            sunWire = GameObject.Find("Sun Wires").GetComponent<Wire>();
            populationWire = GameObject.Find("Population Wires").GetComponent<Wire>();
            technologyWire = GameObject.Find("Technology Wires").GetComponent<Wire>();

            //Start deactivated
            addendumDialogueTrigger.SetActive(false);
            probePrompt.enabled = false;
            coreComputer.ClearAllEntries();

            //If codec has already been downloaded, only display final message
            if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
            {
                complete = true;
                coreComputer.DisplayEntry(4);
            }
        }

        void Update()
        {
            //Debug
            if (Main.debugMode)
            {
                if (Keyboard.current.lKey.isPressed && Keyboard.current.uKey.wasPressedThisFrame)
                    SetActive(true);
            }

            //Activate
            if (!complete && !startedDispensing)
            {
                if (!active)
                {
                    //Turn on
                    if (sunWire.on && populationWire.on && technologyWire.on)
                    {
                        SetActive(true);
                    }
                }
                else
                {
                    //Turn back off
                    if (!sunWire.on || !populationWire.on || !technologyWire.on)
                    {
                        SetActive(false);
                    }
                    //Start dispensing
                    else if (!startedScalingCore)
                    {
                        //Wait for player to translate computer before activating core
                        if (!translator.IsEquipped())
                        {
                            bool computerTranslated = true;
                            for (int i = 1; i <= 3; i++)
                            {
                                if (!coreComputer._dictNomaiTextData[i].IsTranslated)
                                {
                                    computerTranslated = false;
                                    break;
                                }
                            }
                            if (computerTranslated)
                            {
                                coreComputer.ClearAllEntries();
                                startedDispensing = true;

                                //Make sure there is enough time left in the loop
                                if (TimeLoop.GetSecondsRemaining() < minRemainingTime)
                                    TimeLoop.SetSecondsRemaining(minRemainingTime);

                                StartCoroutine(ScaleCore());
                            }
                        }
                    }
                }
            }
        }

        void SetActive(bool value)
        {
            active = value;

            if (value)
            {
                coreComputer.DisplayEntry(1);
                coreComputer.DisplayEntry(2);
                coreComputer.DisplayEntry(3);
            }
            else
            {
                coreComputer.ClearEntry(1);
                coreComputer.ClearEntry(2);
                coreComputer.ClearEntry(3);
            }

            //Update material properties
            int propertyValueIndex = active ? 0 : 1;
            Material[] baseModelMaterials = baseModelRenderer.materials;
            baseModelMaterials[wireMaterialIndex].SetFloat(Wire.SpeedProperty, Wire.speeds[propertyValueIndex]);
            baseModelMaterials[wireMaterialIndex].SetColor(Wire.HighlightColorProperty, Wire.highlightColors[propertyValueIndex]);
            baseModelMaterials[wireMaterialIndex].SetColor(Wire.BaseColorProperty, Wire.baseColors[propertyValueIndex]);
        }

        void ProbeAnchored()
        {
            if (!coreScaled)
                return;

            //Check if the probe is now a child of this object's child
            for (int i=0; i<coreTransform.childCount; i++)
            {
                if (transform.GetChild(0).GetChild(i) == probe.transform && !animationStarted)
                {
                    chimeMusic.FadeOut(2f); //Fade out music
                    StartCoroutine(nameof(CodecAnimation));
                }
            }
        }

        IEnumerator ScaleCore()
        {
            startedScalingCore = true;

            while (coreTransform.localScale.x < coreMaxScale)
            {
                coreTransform.localScale += Vector3.one * coreScaleSpeed * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

            coreScaled = true;
            probePrompt.enabled = true;
        }

        IEnumerator CodecAnimation()
        {
            animationStarted = true;
            float startTime = Time.time;

            //Prevent player from recalling scout
            probeLauncher._isRetrieving = true;

            //Disable probe launch prompt
            probePrompt.enabled = false;

            //Suppress probe particles
            probeParticles.Suppress(true);

            //Disable the other 3 Codec projections
            sunWire.DisableProjection();
            populationWire.DisableProjection();
            technologyWire.DisableProjection();

            //Start spinning the other 3 codec projectors
            sunWire.ForceRotateProjector();
            populationWire.ForceRotateProjector();
            technologyWire.ForceRotateProjector();

            //Start the animation
            animator.Play(AnimatorState);

            //Save probe light's initial intensity
            float[] probeLightsInitialIntensity = new float[probeLights.Length];
            for (int i=0; i<probeLights.Length;  i++)
                probeLightsInitialIntensity[i] = probeLights[i].intensity;

            //Probe sinks into dispenser
            float sinkStartTime = Time.time;
            Vector3 probeStartPosition = probe.GetAnchor()._localImpactPos;
            Vector3 probeFinalPosition = -probe.GetAnchor()._localImpactPos.normalized * 0.1f;
            while (Time.time - sinkStartTime < sinkDuration)
            {
                float t = (Time.time - sinkStartTime) / sinkDuration;
                probe.GetAnchor()._localImpactPos = Vector3.Lerp(probeStartPosition, probeFinalPosition, t);

                //Fade lights out
                for (int i=0; i<probeLights.Length; i++)
                    probeLights[i].intensity = Mathf.Lerp(probeLightsInitialIntensity[i], 0.01f, t);

                yield return new WaitForEndOfFrame();
            }

            //Start spinning the probe
            Coroutine spinProbeCoroutine = StartCoroutine(RotateProbe());

            //Wait for animation to be complete
            yield return new WaitForSeconds(totalDuration - (Time.time - startTime));

            //Enable the dialogue trigger
            addendumDialogueTrigger.SetActive(true);
            InteractReceiver addendumDialogueInteractReceiver = addendumDialogueTrigger.GetComponent<InteractReceiver>();
            addendumDialogueInteractReceiver._screenPrompt._text = "<CMD> Write Addendum"; //These will need to be translated
            addendumDialogueInteractReceiver._noCommandIconPrompt._text = "Write Addendum";

            //Play the addendum particles
            addendumParticles.Play();

            //Wait for the player to have the astral codec ship log
            yield return new WaitUntil(() => PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1);

            //Disable the dialogue trigger's collider
            addendumDialogueTrigger.GetComponent<Collider>().enabled = false;

            //Stop the addendum particles
            addendumParticles.Stop();

            //Stop spinning the probe
            StopCoroutine(spinProbeCoroutine);

            //Release probe
            probe.Unanchor();
            probeLauncher._isRetrieving = false;

            //Restore probe light
            for (int i = 0; i < probeLights.Length; i++)
                probeLights[i].intensity = probeLightsInitialIntensity[i];

            //Restore probe particles
            probeParticles.Suppress(false);

            //Display last computer entry
            coreComputer.DisplayEntry(4);

            //Shatter the core
            coreTransform.localScale = Vector3.zero;
            shatterEffect.gameObject.SetActive(true);

            //Switch final end times music
            MusicHandler.SetFinalEndTimes();
        }

        IEnumerator RotateProbe()
        {
            float probeRotationSpeed = 0;

            while (true)
            {
                if (probeRotationSpeed < probeRotationMaxSpeed)
                    probeRotationSpeed += probeRotationAcceleration * Time.deltaTime;
                probe.transform.RotateAround(transform.position, probe.transform.forward, probeRotationSpeed * Time.deltaTime);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
