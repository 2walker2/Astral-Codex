using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Builder;
using NewHorizons.Utility;
using UnityEngine.PostProcessing;
using System.Diagnostics;
using System;
using Newtonsoft.Json.Linq;

namespace AstralCodex
{
    class TesseractInteraction : MonoBehaviour
    {
        const string TesseractEnteredCondition = "CODEX_ENTERED_TESSERACT";

        #region Private Variables
        GameObject activationEffect; //The prefab to instantiate when the player enters the tesseract
        //GameObject fourDParticles; //The particles to enable when the player first enters the tesseract
        //GameObject fourDParticles2; //The particles to enable after the player has waited in the tesseract
        int fourDLayer = 0; //The player's current tesseract layer (0=normal, 1=entered, 2=waited)
        GameObject skySphere; //The GameObject holding the ghost matter skybox overlay
        int skySphereDisabled = 0; //A timer used for disabling the sky sphere a few frames after the solar system loads
        List<ParticleSystem> exteriorProbeLidarProjections = new List<ParticleSystem>(); //The lidar scan particles of the Chime's exterior probes
        NomaiComputer statusComputer; //The computer that displays the status of the Chime
        Animator solarPanelsAnimator; //The Animator that controls the solar panels rising and falling
        Shape chimeSignalDetectionShape; //The shape that notifies the player of an unidentified signal for the Chime transmitter
        Camera playerCamera; //The player's camera
        GameObject chimeInteriorRevealVolume; //The reveal volume for the interior of the Chime
        GameObject tesseractRevealVolume; //The reveal volume for passing through the tesseract
        OWTriggerVolume triggerVolume;
        #endregion

        #region Initialization
        void Start()
        {
            //Component references
            activationEffect = NewHorizons.Utility.Files.AssetBundleUtilities.LoadPrefab(AssetHandler.assetBundlePath, "Assets/Bundle/Tesseract Activation Effect.prefab", Main.modBehaviour);
            //fourDParticles = transform.Find("4DParticles").gameObject;
            //fourDParticles2 = transform.Find("4DParticles2").gameObject;
            skySphere = SearchUtilities.Find("Skybox/Sky Sphere");
            statusComputer = SearchUtilities.Find("ChimeStatusComputer").GetComponent<NomaiComputer>();
            statusComputer.ClearAllEntries();
            solarPanelsAnimator = SearchUtilities.Find("Station/Solar Panels").GetComponent<Animator>();
            chimeSignalDetectionShape = SearchUtilities.Find("Chime Signal").GetComponent<Shape>();
            playerCamera = Locator.GetPlayerCamera().GetComponent<Camera>();
            chimeInteriorRevealVolume = SearchUtilities.Find("ChimeInteriorRevealVolume");
            tesseractRevealVolume = SearchUtilities.Find("ChimeTesseractRevealVolume");
            triggerVolume = GetComponent<OWTriggerVolume>();

            GameObject exteriorProbeRoot = SearchUtilities.Find("Exterior Lidar Probes");
            if (exteriorProbeRoot != null)
            {
                ParticleSystem[] particleSystems = exteriorProbeRoot.GetComponentsInChildren<ParticleSystem>();
                foreach (ParticleSystem particleSystem in particleSystems)
                {
                    if (particleSystem.gameObject.name == "ScanSource")
                        exteriorProbeLidarProjections.Add(particleSystem);
                }
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND EXTERIOR LIDAR PROBES");

            //Disable signal at start
            chimeSignalDetectionShape.enabled = false;

            //Disable reveal volumes at start
            chimeInteriorRevealVolume.SetActive(false);
            tesseractRevealVolume.SetActive(false);

            //Restore tesseract state from previous loops
            if (PlayerData.GetPersistentCondition(TesseractEnteredCondition))
                EnteredTesseract(true, false);

            //Add the animation component as well
            gameObject.AddComponent<TesseractAnimation>();

            //Register trigger volume callback
            triggerVolume.OnEntry += OnEntry;

            //Hide body if player is playing NomaiVR
            //Modification of NomaiVR's code that places the body on the visible to probe layer
            // https://github.com/Raicuparta/nomai-vr/blob/9e0091e9c9d1ecd0aced42bde59b750237600e08/NomaiVR/Hands/HandsController.cs#L109
            if (Main.modHelper.Interaction.ModExists("Raicuparta.NomaiVR"))
            {
                Main.modHelper.Console.WriteLine("NomaiVR is installed, hiding player body");

                var bodyModels = Locator.GetPlayerBody().transform.Find("Traveller_HEA_Player_v2");

                var renderers = bodyModels.GetComponentsInChildren<SkinnedMeshRenderer>(true);
                foreach (var renderer in renderers)
                {
                    // still make it cast shadow like base nomaivr does
                    renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                }
            }
        }

        
        #endregion

        #region Update
        void LateUpdate()
        {
            //Initially disable skySphere
            if (fourDLayer == 0 && skySphereDisabled == 5)
            {
                if (skySphere != null)
                    skySphere.SetActive(false);
            }
            skySphereDisabled++;

            //Ensure correct layers remain visible
            if (playerCamera != null && fourDLayer != 0)
            {
                // Visible to Probe visible unless on layer 0
                if ((playerCamera.cullingMask & (1 << 22)) == 0)
                    playerCamera.cullingMask += (1 << 22);
            }
        }
        #endregion

        #region Player Enters/Exits/Waits in Tesseract

        private void OnEntry(GameObject hitObj)
        {
            //Move into 4D
            if (hitObj.CompareTag("PlayerDetector"))
            {
                //Main.modHelper.Console.WriteLine($"ENTERED TESSERACT", MessageType.Success);
                if (fourDLayer == 0)
                    EnteredTesseract(true);
                else
                    EnteredTesseract(false);
            }
        }

        private void EnteredTesseract(bool value, bool displayEffect = true)
        {
            if (value)
                statusComputer.DisplayAllEntries();
            else
                statusComputer.ClearAllEntries();

            //Disable probe launcher overlay
            Transform[] probeLauncherRenderers = SearchUtilities.Find("Props_HEA_ProbeLauncher_ProbeCamera").GetComponentsInChildren<Transform>();
            foreach (Transform r in probeLauncherRenderers) r.gameObject.layer = 28;

            //Instantiate effect
            if (displayEffect)
            {
                GameObject activationEffectInstance = Instantiate(activationEffect);
                activationEffectInstance.AddComponent<TesseractActivationEffect>();
                activationEffectInstance.SetActive(true);
            }

            //Enable skybox
            if (skySphere != null)
                skySphere.SetActive(value);

            //Adjust post processing
            PostProcessingGameplaySettings postProcessingSettings = Locator.GetPlayerCamera().postProcessingSettings;
            if (value)
            {
                postProcessingSettings.colorGrading.temperature = -10;
                postProcessingSettings.colorGrading.tint = -30;
            }
            else
            {
                postProcessingSettings.colorGrading.temperature = 0;
                postProcessingSettings.colorGrading.tint = 0;
            }

            //Update travel music
            MusicHandler.SetTravelMusic(value);

            //Trigger solar panels animation
            solarPanelsAnimator.SetBool("Open", value);

            //Toggle exterior lidar probes
            foreach (ParticleSystem p in exteriorProbeLidarProjections)
            {
                if (value)
                    p.Stop();
                else
                    p.Play();
            }

            //Toggle signal
            chimeSignalDetectionShape.enabled = value;

            //Toggle reveal volumes
            chimeInteriorRevealVolume.SetActive(value);
            tesseractRevealVolume.SetActive(value);

            //Set persistent condition
            PlayerData.SetPersistentCondition(TesseractEnteredCondition, value);

            if (value)
                fourDLayer = 1;
            else
            {
                fourDLayer = 0;
                if ((playerCamera.cullingMask & (1 << 22)) != 0)
                    playerCamera.cullingMask -= (1 << 22);
            }
        }
        #endregion
    }
}
