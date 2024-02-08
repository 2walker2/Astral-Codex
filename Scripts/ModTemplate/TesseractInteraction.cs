using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Builder;
using NewHorizons.Utility;
using UnityEngine.PostProcessing;
using System.Diagnostics;

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
        AudioClip defaultTravelMusic; //The default travel music so it can be restored if the player resets the tesseract
        List<ParticleSystem> exteriorProbeLidarProjections = new List<ParticleSystem>(); //The lidar scan particles of the Chime's exterior probes
        NomaiComputer statusComputer; //The computer that displays the status of the Chime
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

            //Save default travel music and update travel audio source settings
            GlobalMusicController globalMusicController = Locator.GetGlobalMusicController();
            if (globalMusicController != null)
            {
                defaultTravelMusic = globalMusicController._travelSource.clip;
                globalMusicController._travelSource._audioLibraryClip = 0;
                globalMusicController._travelSource._clipArrayIndex = 0;
                globalMusicController._travelSource._clipArrayLength = 0;
                globalMusicController._travelSource._clipSelectionOnPlay = OWAudioSource.ClipSelectionOnPlay.MANUAL;
            }

            //Restore tesseract state from previous loops
            if (PlayerData.GetPersistentCondition(TesseractEnteredCondition))
                EnteredTesseract(true, false);

            //Add the animation component as well
            gameObject.AddComponent<TesseractAnimation>();
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
            if (Camera.main != null && fourDLayer != 0)
            {
                // Visible to Probe visible unless on layer 0
                if ((Camera.main.cullingMask & (1 << 22)) == 0)
                    Camera.main.cullingMask += (1 << 22);
            }
        }
        #endregion

        #region Player Enters/Exits/Waits in Tesseract
        private void OnTriggerEnter(Collider other)
        {
            //Move into 4D
            if (other.gameObject.CompareTag("Player"))
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
            Transform[] probeLauncherRenderers = GameObject.Find("Props_HEA_ProbeLauncher_ProbeCamera").GetComponentsInChildren<Transform>();
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
                postProcessingSettings.colorGrading.temperature = -25;
                postProcessingSettings.colorGrading.tint = -50;
            }
            else
            {
                postProcessingSettings.colorGrading.temperature = 0;
                postProcessingSettings.colorGrading.tint = 0;
            }

            //Update travel music
            if (value)
                Locator.GetGlobalMusicController()._travelSource.clip = AssetHandler.audioClips["fourDTravelMusic"];
            else
                Locator.GetGlobalMusicController()._travelSource.clip = defaultTravelMusic;

            //Toggle exterior lidar probes
            foreach (ParticleSystem p in exteriorProbeLidarProjections)
            {
                if (value)
                    p.Stop();
                else
                    p.Play();
            }

            //Set persistent condition
            PlayerData.SetPersistentCondition(TesseractEnteredCondition, value);

            if (value)
                fourDLayer = 1;
            else
            {
                fourDLayer = 0;
                if ((Camera.main.cullingMask & (1 << 22)) != 0)
                    Camera.main.cullingMask -= (1 << 22);
            }
                
        }
        #endregion
    }
}
