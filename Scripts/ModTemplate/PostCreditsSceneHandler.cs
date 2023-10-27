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
                InitializeScene();
        }
        #endregion

        #region Scene Configuration
        void InitializeScene()
        {
            //Particles on end screen
            if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
            {
                GameObject probe = GameObject.Find("Probe");
                if (probe != null)
                {
                    AssetBundle.UnloadAllAssetBundles(false);
                    //ModHelper.Console.WriteLine($"FOUND PROBE", MessageType.Success);
                    AssetBundle assetBundle = Main.modHelper.Assets.LoadBundle("planets/assets/astral_codex");
                    GameObject particles = (GameObject)Instantiate(assetBundle.LoadAsset("Assets/Bundle/SignalParticles.prefab"), probe.transform);
                    particles.GetComponentInChildren<ParticleSystem>().Play();
                    //Audio (doesn't work)
                    /*AudioClip signal = (AudioClip)assetBundle.LoadAsset("Assets/Bundle/Audio/Signal.wav");
                    Destroy(probe.GetComponentInChildren<OWAudioSource>());
                    AudioSource probeAudio = probe.GetComponentInChildren<AudioSource>();
                    probeAudio.clip = signal;
                    probeAudio.volume = 5f;*/
                    assetBundle.Unload(false);
                }
            }
        }
        #endregion
    }
}
