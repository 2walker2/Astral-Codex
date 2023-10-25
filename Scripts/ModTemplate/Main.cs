using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;
using Harmony;
using System.Collections;
using System.Linq;
using NewHorizons.Utility;
using UnityEngine.InputSystem;

namespace AstralCodex
{
    public class Main : ModBehaviour
    {
        //Constant values
        public static string assetBundlePath = "planets/assets/astral_codex";

        //Constant references
        public static IModHelper modHelper;
        public static IModBehaviour modBehaviour;
        public static INewHorizons newHorizons;
        public static Main S;

        
        List<RenderTexture> flashbackTextureList;
        bool flashbackOverridden = false;
        int flashbackImageCount = 8;
        int[] flashbackMultiplicity = new int[] { -1, 4, 4, 4, 4, 4, 4, 25, 4 };

        bool spaceTimeStabilityScene = false;
        NomaiExperimentBlackHole experimentBlackHole;

        void Awake()
        {
            //Initialize instance
            if (S == null) S = this;

            //Set scene loading
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void Start()
        {
            //Get the mod helper (accessible starting here)
            modHelper = ModHelper;
            ModHelper.Console.WriteLine($"ASTRAL CODEX mod loaded", MessageType.Success);

            //Get the mod behaviour
            modBehaviour = this;

            //Initialize New Horizons configs
            newHorizons = ModHelper.Interaction.TryGetModApi<INewHorizons>("xen.NewHorizons");
            newHorizons.LoadConfigs(this);

            //Locate the gameObject that holds this script
            GameObject modBehaviourGO = SearchUtilities.Find(ModHelper.Manifest.UniqueName);
            if (modBehaviourGO != null)
            {
                //Add asset handler component
                modBehaviourGO.AddComponent<AssetHandler>();

                //Add scene handler components
                modBehaviourGO.AddComponent<TitleScreenHandler>();
                modBehaviourGO.AddComponent<SolarSystemHandler>();
                modBehaviourGO.AddComponent<EyeSceneHandler>();
            }
            else
                ModHelper.Console.WriteLine("FAILED TO FIND MOD BEHAVIOUR GAMEOBJECT", MessageType.Error);

            //Load flashback textures
            flashbackTextureList = new List<RenderTexture>();
            for (int renderTextureIndex = flashbackImageCount; renderTextureIndex > 0; renderTextureIndex--)
            {
                Texture2D texture = ModHelper.Assets.GetTexture("textures/" + renderTextureIndex.ToString() + ".png");
                RenderTexture renderTexture = new RenderTexture(480, 270, 0);
                renderTexture.enableRandomWrite = true;
                RenderTexture.active = renderTexture;
                Graphics.Blit(texture, renderTexture);
                flashbackTextureList.AddRange(Enumerable.Repeat(renderTexture, flashbackMultiplicity[renderTextureIndex]));
            }

            //Setup
            newHorizons.GetStarSystemLoadedEvent().AddListener((string system) =>
            {
                if (system == "SolarSystem")
                {
                    //Reset flashback overriden
                    flashbackOverridden = false;

                    //Initialize the spacetime stability system
                    spaceTimeStabilityScene = true;
                    GameObject experimentBlackHoleGO = SearchUtilities.Find("CaveTwin_Body/Sector_CaveTwin/Sector_NorthHemisphere/Sector_NorthSurface/Sector_TimeLoopExperiment/Interactables_TimeLoopExperiment/WarpCoreExperiment/SingularityEffects/Singularity_BlackHole");
                    if (experimentBlackHoleGO != null)
                        experimentBlackHole = experimentBlackHoleGO.GetComponent<NomaiExperimentBlackHole>();
                    else
                        ModHelper.Console.WriteLine("FAILED TO FIND EXPERIMENT BLACK HOLE", MessageType.Error);
                }
                else if (system == "EyeOfTheUniverse")
                {
                    //Disable space time stability system
                    spaceTimeStabilityScene = false;
                }
            });
        }

        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            if (scene.name == "Credits_Final")
            {
                //Update end text
                if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
                {
                    if (DialogueConditionManager.SharedInstance.GetConditionState("PROBE_ENTERED_EYE"))
                        GameObject.Find("14.3 Billion Years Later").GetComponent<Text>().text = "14.3 Billion Years Later\n\nThe Codec is Rediscovered";
                }
            }
            else if (scene.name == "PostCreditScene")
            {
                //Particles on end screen
                if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
                {
                    GameObject probe = GameObject.Find("Probe");
                    if (probe != null)
                    {
                        AssetBundle.UnloadAllAssetBundles(false);   
                        //ModHelper.Console.WriteLine($"FOUND PROBE", MessageType.Success);
                        AssetBundle assetBundle = ModHelper.Assets.LoadBundle("planets/assets/astral_codex");
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
        }

        void Update()
        {
            if (Locator.GetDeathManager().IsPlayerDying())
            {
                //Override flashback when player dies
                if (!flashbackOverridden)
                {
                    if ((!PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_projection_fact") || PlayerData._currentGameSave.shipLogFactSaves["codex_projection_fact"].revealOrder <= -1) && TimeLoop._isTimeFlowing)
                    {
                        Locator.GetShipLogManager().RevealFact("codex_flashback_fact");
                        GameObject flashbackCamera = SearchUtilities.Find("FlashbackCamera");
                        if (flashbackCamera != null)
                        {
                            //ModHelper.Console.WriteLine("OVERWRITING FLASHBACK", MessageType.Success);
                            FlashbackRecorder flashbackRecorder = flashbackCamera.GetComponent<FlashbackRecorder>();
                            RenderTexture[] flashbackTextureArray = new RenderTexture[flashbackTextureList.Count];
                            for (int i = 0; i < flashbackTextureList.Count; i++)
                            {
                                flashbackTextureArray[i] = new RenderTexture(480, 270, 0);
                                flashbackTextureArray[i].enableRandomWrite = true;
                                Graphics.CopyTexture(flashbackTextureList[i], flashbackTextureArray[i]);
                            }
                            flashbackRecorder._renderTextureArray = flashbackTextureArray;
                            flashbackRecorder._numCapturedSnapshots = flashbackTextureArray.Length;

                            GameObject flashbackScreen = SearchUtilities.Find("FlashbackCamera/Screen");
                            if (flashbackScreen != null)
                                flashbackScreen.GetComponent<MeshRenderer>().material = AssetHandler.materials["spritesDefault"];
                            else
                                ModHelper.Console.WriteLine("FAILED TO FIND FLASHBACK SCREEN", MessageType.Error);
                        }
                        else
                            ModHelper.Console.WriteLine("FAILED TO FIND FLASHBACK CAMERA", MessageType.Error);
                    }
                    flashbackOverridden = true;
                }
            }

            //Prevent spacetime from breaking
            if (spaceTimeStabilityScene)
            {
                if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_lingering_chime_tesseract") && PlayerData._currentGameSave.shipLogFactSaves["codex_lingering_chime_tesseract"].revealOrder > -1)
                {
                    TimeLoopCoreController.s_paradoxExists = false; //Prevent from breaking via ATP duplication
                    experimentBlackHole._duplicateActive = false; //Prevent from breaking via HEL experiment
                }
            }

            //Debug warp to Chime
            if (Keyboard.current.lKey.isPressed && Keyboard.current.cKey.wasPressedThisFrame)
            {
                OWRigidbody playerBody = Locator.GetPlayerBody();
                if (playerBody != null)
                {
                    playerBody.SetPosition(Locator.GetSunTransform().position + new Vector3(0, -34998, 0));
                    playerBody.SetVelocity(Vector3.zero);
                    playerBody.SetAngularVelocity(Vector3.zero);
                }
            }
        }
    }

    // Example of accessing game code.
    /*LoadManager.OnCompleteSceneLoad += (scene, loadScene) =>
    {
        if (loadScene != OWScene.SolarSystem) return;
        var playerBody = FindObjectOfType<PlayerBody>();
        ModHelper.Console.WriteLine($"Found player body, and it's called {playerBody.name}!",
            MessageType.Success);
    };*/
}
