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

namespace AstralCodex
{
    internal class CodexDispenser : MonoBehaviour
    {
        const string AnimatorState = "DispenseCodec";

        bool active = false;
        bool animationStarted = false;

        //Timing information
        float totalDuration = 68; //Total duration of the animation
        float sinkDuration = 5; //How long it takes the probe to sink into the dispenser
        float probeMaxRotationSpeed = 500; //How fast the probe rotates once it's inside the dispenser
        AnimationCurve probeRotationSpeedCurve; //The curve used to update the probe's rotation speed
        float particleBurstTime = 29; //The time when the particle burst occurs

        SurveyorProbe probe;
        ProbeLauncher probeLauncher;
        OWRigidbody owRigidbody;
        ProbePromptReceiver probePrompt;
        Animator animator;
        GameObject addendumDialogueTrigger;

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
            owRigidbody = GetComponent<OWRigidbody>();
            probePrompt = GetComponentInChildren<ProbePromptReceiver>();
            animator = transform.parent.parent.GetComponentInChildren<Animator>();
            addendumDialogueTrigger = transform.Find("CodecAddendumDialogue").gameObject;

            sunWire = GameObject.Find("Sun Wires").GetComponent<Wire>();
            populationWire = GameObject.Find("Population Wires").GetComponent<Wire>();
            technologyWire = GameObject.Find("Technology Wires").GetComponent<Wire>();

            //Disable initially
            addendumDialogueTrigger.SetActive(false);
            probePrompt.enabled = false;
        }

        void Update()
        {
            if (!animationStarted)
            {
                active = sunWire.on && populationWire.on && technologyWire.on;
                probePrompt.gameObject.SetActive(active);
            }
        }

        void ProbeAnchored()
        {
            if (!active)
                return;

            //Check if the probe is now a child of this object's child
            for (int i=0; i<transform.GetChild(0).childCount; i++)
            {
                if (transform.GetChild(0).GetChild(i) == probe.transform)
                {
                    StartCoroutine(nameof(CodecAnimation));
                }
            }
        }

        IEnumerator CodecAnimation()
        {
            animationStarted = true;
            float startTime = Time.time;
            Main.modHelper.Console.WriteLine("STARTING CODEC ANIMATION");

            //Prevent player from recalling scout
            probeLauncher._isRetrieving = true;

            //Disable probe launch prompt
            probePrompt.gameObject.SetActive(false);

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

            //Wait until the animation is complete
            yield return new WaitForSeconds(totalDuration - (Time.time - startTime));

            //Enable the dialogue trigger
            addendumDialogueTrigger.SetActive(true);
            InteractReceiver addendumDialogueInteractReceiver = addendumDialogueTrigger.GetComponent<InteractReceiver>();
            addendumDialogueInteractReceiver._screenPrompt._text = "<CMD> Write Addendum"; //These will need to be translated
            addendumDialogueInteractReceiver._noCommandIconPrompt._text = "Write Addendum";

            //Wait for the player to interact with the dialogue
            yield return new WaitUntil(() => addendumDialogueInteractReceiver._hasInteracted);

            //Wait for the player to stop interacting with the dialogue
            yield return new WaitUntil(() => !addendumDialogueInteractReceiver._hasInteracted);

            //Release probe
            probe.Unanchor();
            probeLauncher._isRetrieving = false;
            

            yield return null;
        }
    }
}
