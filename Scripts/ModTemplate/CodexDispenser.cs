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

namespace AstralCodex
{
    internal class CodexDispenser : MonoBehaviour
    {
        const string AnimatorState = "DispenseCodec";
        const string CoreActivatedCondition = "CODEX_ACTIVATED_CORE";

        bool active = false;
        bool startedScalingCore = false;
        bool coreScaled = false;
        bool animationStarted = false;

        //Timing information
        float totalDuration = 57.5f; //68; //Total duration of the animation
        float sinkDuration = 5; //How long it takes the probe to sink into the dispenser
        float probeRotationAcceleration = 100; //How fast the probe's rotation speed increases
        float probeRotationMaxSpeed = 250; //How fast the probe rotates once it's inside the dispenser
        float particleBurstTime = 29; //The time when the particle burst occurs

        float coreMaxScale = 1;
        float coreScaleSpeed = 0.5f;

        SurveyorProbe probe;
        ProbeLauncher probeLauncher;
        ProbePromptReceiver probePrompt;
        Animator animator;
        GameObject addendumDialogueTrigger;
        NomaiComputer coreComputer;
        NomaiTranslator translator;
        Transform coreTransform;
        OWAudioSource chimeMusic;

        Wire sunWire;
        Wire populationWire;
        Wire technologyWire;

        void Start()
        {
            //Initialize callback
            Locator.GetProbe().GetAnchor().OnAnchorToSurface += ProbeAnchored;

            //Component references
            probe = Locator.GetProbe();
            probeLauncher = Locator.GetPlayerCamera().GetComponentInChildren<ProbeLauncher>();
            probePrompt = GetComponentInChildren<ProbePromptReceiver>();
            animator = transform.parent.GetComponentInChildren<Animator>();
            addendumDialogueTrigger = SearchUtilities.Find("CodecAddendumDialogue").gameObject;
            coreComputer = SearchUtilities.Find("CodexCoreComputer").GetComponent<NomaiComputer>();
            translator = SearchUtilities.Find("Player_Body/PlayerCamera/NomaiTranslatorProp").GetComponent<NomaiTranslator>();
            coreTransform = transform.GetChild(0);
            chimeMusic = SearchUtilities.Find("Station/Audio/Music").GetComponent<OWAudioSource>();

            sunWire = GameObject.Find("Sun Wires").GetComponent<Wire>();
            populationWire = GameObject.Find("Population Wires").GetComponent<Wire>();
            technologyWire = GameObject.Find("Technology Wires").GetComponent<Wire>();

            //Start deactivated
            addendumDialogueTrigger.SetActive(false);
            probePrompt.enabled = false;
            coreComputer.ClearAllEntries();

            //Restore previous state
            if (PlayerData.GetPersistentCondition(CoreActivatedCondition))
                Activate();
        }

        void Update()
        {
            //Debug
            if (Main.debugMode)
            {
                if (Keyboard.current.lKey.isPressed && Keyboard.current.uKey.wasPressedThisFrame)
                    Activate();
            }

            //Activate
            if (!active)
            {
                if (sunWire.on && populationWire.on && technologyWire.on)
                {
                    Activate();
                }
            }
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
                        StartCoroutine(ScaleCore());
                    }
                }
            }
        }

        void Activate()
        {
            active = true;
            PlayerData.SetPersistentCondition(CoreActivatedCondition, true);
            coreComputer.DisplayEntry(1);
            coreComputer.DisplayEntry(2);
            coreComputer.DisplayEntry(3);
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
            Main.modHelper.Console.WriteLine("STARTING CODEC ANIMATION");

            //Prevent player from recalling scout
            probeLauncher._isRetrieving = true;

            //Disable probe launch prompt
            probePrompt.enabled = false;

            //Start the animation
            animator.Play(AnimatorState);

            //Probe sinks into dispenser
            float sinkStartTime = Time.time;
            Vector3 probeStartPosition = probe.GetAnchor()._localImpactPos;
            while (Time.time - sinkStartTime < sinkDuration)
            {
                float t = (Time.time - sinkStartTime) / sinkDuration;
                probe.GetAnchor()._localImpactPos = Vector3.Lerp(probeStartPosition, Vector3.zero, t);

                yield return new WaitForEndOfFrame();
            }

            //Spin probe and wait for animation to be complete
            float probeRotationSpeed = 0;
            while (Time.time - startTime < totalDuration)
            {
                if (probeRotationSpeed < probeRotationMaxSpeed)
                    probeRotationSpeed += probeRotationAcceleration * Time.deltaTime;
                probe.transform.Rotate(Vector3.one * probeRotationSpeed * Time.deltaTime);
                yield return new WaitForEndOfFrame();
            }

            Main.modHelper.Console.WriteLine("FINISHING CODEC ANIMATION");

            //Enable the dialogue trigger
            addendumDialogueTrigger.SetActive(true);
            InteractReceiver addendumDialogueInteractReceiver = addendumDialogueTrigger.GetComponent<InteractReceiver>();
            addendumDialogueInteractReceiver._screenPrompt._text = "<CMD> Write Addendum"; //These will need to be translated
            addendumDialogueInteractReceiver._noCommandIconPrompt._text = "Write Addendum";

            //Wait for the player to interact with the dialogue
            yield return new WaitUntil(() => addendumDialogueInteractReceiver._hasInteracted);

            //Wait for the player to stop interacting with the dialogue
            yield return new WaitUntil(() => !addendumDialogueInteractReceiver._hasInteracted);

            //Disable the dialogue trigger
            addendumDialogueTrigger.SetActive(false);

            //Release probe
            probe.Unanchor();
            probeLauncher._isRetrieving = false;

            //Display last computer entry
            coreComputer.DisplayEntry(4);

            //Scale down core
            while (coreTransform.localScale.x > 0)
            {
                coreTransform.localScale -= Vector3.one * coreScaleSpeed * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            transform.localScale = Vector3.zero;

            //Switch final end times music
            MusicHandler.SetFinalEndTimes();

            Main.modHelper.Console.WriteLine("CODEC ANIMATION COROUTINE COMPLETE");
        }
    }
}
