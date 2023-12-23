using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AstralCodex
{
    class PostCreditsSceneHandler : MonoBehaviour
    {

        GameObject sceneRoot;
        GameObject probe;
        GameObject particles;
        ParticleSystem particlesSystem;

        const string SceneName = "PostCreditScene";


        #region Initialization
        void Awake()
        {
            //Initialize the scene loaded callback
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        #endregion

        #region Scene Loaded Callback
        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            if (scene.name == SceneName)
            {
                NewHorizons.Utility.OWML.Delay.FireOnNextUpdate(InitializeScene);

                //Debug force probe to show
                DialogueConditionManager.SharedInstance.SetConditionState("PROBE_ENTERED_EYE", true);
            }
        }
        #endregion

        #region Scene Configuration
        void InitializeScene()
        {
            //Particles on end screen
            if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
            {
                if (DialogueConditionManager.SharedInstance.GetConditionState("PROBE_ENTERED_EYE"))
                {
                    sceneRoot = SearchUtilities.Find("PostCreditsScene");
                    probe = sceneRoot.transform.Find("Probe").gameObject;
                    if (probe != null)
                    {
                        GameObject particlesPrefab = NewHorizons.Utility.Files.AssetBundleUtilities.LoadPrefab(AssetHandler.assetBundlePath, "Assets/Bundle/SignalParticles.prefab", Main.modBehaviour);
                        particles = Instantiate(particlesPrefab, probe.transform);
                        particles.SetActive(true); //Not sure why they're instantiated deactivated but this should fix it

                        //Adjust the scale and orientation of the particles
                        Transform eyeTransform = particles.transform.GetChild(0).GetChild(0);
                        eyeTransform.localScale = Vector3.one * 25;
                        Transform eyeCenterTransform = eyeTransform.transform.GetChild(0);
                        eyeCenterTransform.localScale = Vector3.one * 250;

                        particlesSystem = particles.GetComponentInChildren<ParticleSystem>();
                        particlesSystem.Play();


                        //Audio
                        AudioClip signal = NewHorizons.Utility.Files.AssetBundleUtilities.Load<AudioClip>(AssetHandler.assetBundlePath, "Assets/Bundle/Audio/Signal.wav", Main.modBehaviour);
                        OWAudioSource signalSource = probe.GetComponentInChildren<OWAudioSource>();
                        signalSource._audioLibraryClip = 0;
                        signalSource._clipArrayIndex = 0;
                        signalSource._clipArrayLength = 0;
                        signalSource._clipSelectionOnPlay = OWAudioSource.ClipSelectionOnPlay.MANUAL;
                        signalSource.clip = signal;
                        signalSource.dopplerLevel = 0;
                    }
                }
            }
        }
        #endregion
    }
}
