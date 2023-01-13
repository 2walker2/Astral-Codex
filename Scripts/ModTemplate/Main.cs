using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;
using Harmony;
using System.Collections;
using System.Linq;
using NewHorizons.Utility;

namespace AstralCodex
{
    public class Main : ModBehaviour
    {
        public static IModHelper modHelper;
        public static INewHorizons newHorizons;
        public static Main instance;

        public Dictionary<string, Material> materials;

        List<string> ghostMatterCrystals;
        Dictionary<string, string> materialsToFind;
        Dictionary<string, Type> componentsToAdd;
        Dictionary<string, Vector3> rotatingObjects;

        void Awake()
        {
            //Initialize instance
            if (instance == null) instance = this;
            //Create ghost matter crystal material list
            ghostMatterCrystals = new List<string>() { 
                "Station/Visual/Model", 
                "BrambleScroll2/Props_NOM_Scroll/Props_NOM_Scroll_Geo", 
                "TranslationCairn1", 
                "TranslationCairn2",
                "InterloperRecorderBreach",
                "InterloperRecorderWarning",
                "TranslationProbe1/Model", 
                "TranslationProbe2/ScaleRoot/Model",
                "TranslationProbe3/Model",
                "ChimeSign"
            };
            //Create materials list
            materialsToFind = new Dictionary<string, string>()
            {
                {"RedReference", "red"},
                {"GreenReference", "green" },
                {"LightReference", "light" },
                {"BlackReference", "black" }
            };
            //Create components list
            componentsToAdd = new Dictionary<string, Type>()
            {
                {"Tesseract", typeof(Tesseract) },
                {"SunWire", typeof(SunWire) },
                {"PopulationWire", typeof(PopulationWire) },
                {"TechnologyWire", typeof(TechnologyWire) },
                {"TimberHearthSpacecraftDetector", typeof(SpacecraftDetector) },
                {"AshTwinSpacecraftDetector", typeof(SpacecraftDetector) },
                {"Monolith", typeof(Monolith) },
                {"LingeringChime_Body/Sector/Water/WaterVolume", typeof(GhostMatterSubmerge) },
                {"PopulationScannerOrigin", typeof(PopulationTrails) },
                {"SpacecraftScannerOrigin", typeof(SpacecraftTrails) },
                {"Station/ProbeParticles", typeof(ProbeParticles) },
                {"Station/ThornParticles", typeof(ThornParticles) },
                {"TranslationProbe2", typeof(EmberProjectionActivate) },
                {"Sector_CaveTwin/Railing 1", typeof(BoxCollider) }, {"Sector_CaveTwin/Railing 2", typeof(BoxCollider) }, {"Sector_CaveTwin/Railing 3", typeof(BoxCollider) }, {"Sector_CaveTwin/Railing 4", typeof(BoxCollider) }, {"Sector_CaveTwin/Railing 5", typeof(BoxCollider) }, {"Sector_CaveTwin/Railing 6", typeof(BoxCollider) }, {"Sector_CaveTwin/Railing 7", typeof(BoxCollider) }, {"Sector_CaveTwin/Railing 8", typeof(BoxCollider) }, {"Sector_CaveTwin/Railing 9", typeof(BoxCollider) }, {"Sector_CaveTwin/Railing 10", typeof(BoxCollider) },
            };
            //Create rotating objects list
            rotatingObjects = new Dictionary<string, Vector3>()
            {
                {"TranslationProbe2/Projections", new Vector3(0, 2, 0) },
                {"TranslationProbe2/Projections/Sun Scanner/ScanSource/SunScan", new Vector3(0, 8, 0) },
                {"TranslationProbe2/Projections/SpacecraftScanner/ScanSource (4)/DarkBramble", new Vector3(0, 8, 0) },
                {"TranslationProbe2/Projections/SpacecraftScanner/ScanSource (3)/GiantsDeep", new Vector3(0, 8, 0) },
                {"TranslationProbe2/Projections/SpacecraftScanner/ScanSource (2)/BrittleHollow", new Vector3(0, 8, 0) },
                {"TranslationProbe2/Projections/SpacecraftScanner/ScanSource (1)/TimberHearth", new Vector3(0, 8, 0) },
                {"TranslationProbe2/Projections/SpacecraftScanner/ScanSource/HourglassTwins", new Vector3(0, 8, 0) },
            };
            //Set scene loading
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            modHelper = ModHelper;
            //ModHelper.Console.WriteLine($"ASTRAL CODEX mod loaded", MessageType.Success);

            //Get New Horizons interface
            newHorizons = ModHelper.Interaction.TryGetModApi<INewHorizons>("xen.NewHorizons");
            newHorizons.LoadConfigs(this);

            //Setup
            newHorizons.GetStarSystemLoadedEvent().AddListener((string system) =>
            {
                if (system == "SolarSystem")
                {
                    //Flashback override
                    //Define parameters here
                    /*int flashbackImageCount = 8;
                    int repeatAmount = 5;
                    GameObject flashbackCamera = SearchUtilities.Find("FlashbackCamera");
                    if (flashbackCamera != null)
                    {
                        List<RenderTexture> renderTexturesList = new List<RenderTexture>();
                        for (int renderTextureIndex = flashbackImageCount; renderTextureIndex>0; renderTextureIndex--)
                        {
                            Texture2D texture = ModHelper.Assets.GetTexture("textures/"+renderTextureIndex.ToString()+".png");
                            RenderTexture renderTexture = new RenderTexture(480, 270, 0);
                            renderTexture.enableRandomWrite = true;
                            RenderTexture.active = renderTexture;
                            Graphics.Blit(texture, renderTexture);
                            renderTexturesList.AddRange(Enumerable.Repeat(renderTexture, repeatAmount));
                        }
                        RenderTexture[] renderTextureArray = renderTexturesList.ToArray();
                        FlashbackRecorder flashbackRecorder = flashbackCamera.GetComponent<FlashbackRecorder>();
                        flashbackRecorder._renderTextureArray = renderTextureArray;
                        flashbackRecorder._numCapturedSnapshots = flashbackImageCount * repeatAmount;
                    }
                    else
                        ModHelper.Console.WriteLine("FAILED TO FIND FLASHBACK CAMERA");*/

                    //Assign ghost matter material
                    foreach (string ghostMatterCrystal in ghostMatterCrystals)
                    {
                        GameObject crystal = GameObject.Find(ghostMatterCrystal);
                        if (crystal != null)
                        {
                            crystal.AddComponent<GhostMatterMaterial>();
                            //ModHelper.Console.WriteLine($"FOUND " + ghostMatterCrystal, MessageType.Success);
                        }
                    }

                    //Find materials
                    materials = new Dictionary<string, Material>();
                    foreach (KeyValuePair<string, string> pair in materialsToFind)
                    {
                        GameObject obj = GameObject.Find("MaterialReferences/" + pair.Key);
                        if (obj != null)
                        {
                            MeshRenderer rend = obj.GetComponent<MeshRenderer>();
                            if (rend != null)
                            {
                                Material mat = rend.material;
                                if (mat != null)
                                {
                                    materials.Add(pair.Value, mat);
                                    //ModHelper.Console.WriteLine($"FOUND MATERIAL " + pair.Value, MessageType.Success);
                                }
                                else
                                    ModHelper.Console.WriteLine($"FAILED TO FIND MATERIAL " + pair.Value, MessageType.Error);
                            }
                            else
                                ModHelper.Console.WriteLine($"FAILED TO FIND RENDERER FOR MATERIAL " + pair.Value, MessageType.Error);
                        }
                        else
                            ModHelper.Console.WriteLine($"FAILED TO FIND OBJECT FOR MATERIAL " + pair.Value, MessageType.Error);
                    }

                    //Assign scripts
                    foreach (KeyValuePair<string, Type> pair in componentsToAdd)
                    {
                        GameObject obj = SearchUtilities.Find(pair.Key);
                        if (obj != null)
                        {
                            obj.AddComponent(pair.Value);
                            //ModHelper.Console.WriteLine($"FOUND " + pair.Key, MessageType.Success);
                        }
                        else
                            ModHelper.Console.WriteLine($"FAILED TO FIND " + pair.Key, MessageType.Error);
                    }

                    //Assign rotating objects
                    foreach (KeyValuePair<string, Vector3> pair in rotatingObjects)
                    {
                        GameObject obj = SearchUtilities.Find(pair.Key);
                        if (obj != null)
                        {
                            Rotate added = obj.AddComponent<Rotate>();
                            added.speed = pair.Value;
                            //ModHelper.Console.WriteLine($"FOUND ROTATING OBJECT " + pair.Key, MessageType.Success);
                        }
                        else
                            ModHelper.Console.WriteLine($"FAILED TO FIND ROTATING OBJECT " + pair.Key, MessageType.Error);
                    }

                    //Increase ghost matter damage
                    GameObject stationGhostMatter = GameObject.Find("StationGhostMatter");
                    stationGhostMatter.GetComponentInChildren<DarkMatterVolume>()._damagePerSecond = 150;


                    //Enable Ember tree collision
                    GameObject.Find("EmberTwinTree").GetComponentInChildren<MeshCollider>().enabled = true;

                    //Enable Lingering Chime reference frame
                    GameObject rfVolume = GameObject.Find("LingeringChime_Body").transform.GetChild(1).gameObject;
                    if (rfVolume != null)
                    {
                        //ModHelper.Console.WriteLine("FOUND REFERENCE VOLUME", MessageType.Success);
                        rfVolume.SetActive(true);
                    }
                    else
                    {
                        ModHelper.Console.WriteLine("FAILED TO FIND REFERENCE VOLUME", MessageType.Error);
                    }

                    //Make sun cactus not cast shadows
                    GameObject sunCactus = GameObject.Find("Sun_Body/Sector_SUN/Prefab_HGT_Cactus_Single_A");
                    if (sunCactus != null)
                    {
                        //ModHelper.Console.WriteLine("FOUND SUN CACTUS", MessageType.Success);
                        MeshRenderer[] cactusRenderers = sunCactus.GetComponentsInChildren<MeshRenderer>();
                        foreach (MeshRenderer r in cactusRenderers)
                            r.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
                    }

                    //Configure projection pool
                    GameObject projectionRecorder = GameObject.Find("ProjectionRecorder");
                    if (projectionRecorder != null)
                    {
                        Destroy(projectionRecorder.GetComponent<SphereCollider>());
                        Destroy(projectionRecorder.GetComponent<OWCollider>());
                        projectionRecorder.GetComponentInChildren<BoxCollider>().center = new Vector3(0, 0, 0.8f);
                    }
                    GameObject visionStructure = GameObject.Find("StationVision/Structure_NOM_RemoteViewer");
                    if (visionStructure != null)
                    {
                        //ModHelper.Console.WriteLine($"FOUND PROJECTION STRUCTURE", MessageType.Success);
                        Destroy(visionStructure.GetComponentInChildren<MeshRenderer>());
                        Destroy(visionStructure.GetComponentInChildren<MeshCollider>());
                        Destroy(visionStructure.GetComponentInChildren<OWCollider>());
                    }
                    GameObject visionPool = GameObject.Find("StationVision/RemoteViewer_Pool");
                    if (visionPool != null)
                    {
                        //ModHelper.Console.WriteLine($"FOUND PROJECTION POOL", MessageType.Success);
                        visionPool.GetComponent<MeshFilter>().mesh = null;
                    }
                    GameObject visionPedestal = GameObject.Find("StationVision/PedestalAnchor/Prefab_NOM_SharedPedestal");
                    if (visionPedestal != null)
                    {
                        //ModHelper.Console.WriteLine($"FOUND PROJECTION PEDESTAL", MessageType.Success);
                        foreach (SkinnedMeshRenderer r in visionPedestal.GetComponentsInChildren<SkinnedMeshRenderer>())
                            Destroy(r);
                        foreach (MeshRenderer r in visionPedestal.GetComponentsInChildren<MeshRenderer>())
                            Destroy(r);
                        foreach (OWRenderer r in visionPedestal.GetComponentsInChildren<OWRenderer>())
                            Destroy(r);
                        foreach (OWCollider r in visionPedestal.GetComponentsInChildren<OWCollider>())
                            Destroy(r);
                        Destroy(visionPedestal.GetComponentInChildren<BoxCollider>());
                    }
                    //Supposed to make vision overlay gray (doesn't work)
                    /*GameObject visionCamera = GameObject.Find("StationVision/RemoteViewerCamera");
                    if (visionCamera != null)
                    {
                        //ModHelper.Console.WriteLine($"FOUND PROJECTION CAMERA",MessageType.Success);
                        visionCamera.GetComponent<Camera>().cullingMask += (1 << 22);
                        //visionCamera.GetComponent<NomaiViewerImageEffect>()._material.color = new Color(0, 0, 0);
                    }*/

                    //Configure Dark Bramble Recorder
                    GameObject brambleRecorder = SearchUtilities.Find("bramble_chert_recorder");
                    GameObject brambleRecorderDialogue = SearchUtilities.Find("bramble_chert_recorder_dialogue");
                    if (brambleRecorder != null && brambleRecorderDialogue != null)
                    {
                        CharacterDialogueTree brambleRecorderTree = brambleRecorder.GetComponent<CharacterDialogueTree>();
                        CharacterDialogueTree brambleRecorderDialogueTree = brambleRecorderDialogue.GetComponent<CharacterDialogueTree>();
                        brambleRecorderTree._xmlCharacterDialogueAsset = brambleRecorderDialogueTree._xmlCharacterDialogueAsset;
                        Destroy(brambleRecorderDialogue);
                    }
                    else
                        ModHelper.Console.WriteLine("FAILED TO FIND BRAMBLE RECORDER OR DIALOGUE", MessageType.Error);
                }
                else if (system == "EyeOfTheUniverse")
                {
                    //Ensure probe particles don't disappear when going to the Eye
                    GameObject probeParticles = SearchUtilities.Find("ProbeParticles");
                    if (probeParticles != null)
                    {
                        probeParticles.AddComponent<ProbeParticles>();
                        probeParticles.transform.GetChild(0).GetChild(0).localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    }

                    //Configure museum plaque
                    GameObject plaque = SearchUtilities.Find("ProbePlaque");
                    GameObject plaqueDialogue = SearchUtilities.Find("PlaqueDialogue");
                    if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
                    {
                        if (plaqueDialogue != null)
                        {
                            CharacterDialogueTree plaqueDialogueTree = plaqueDialogue.GetComponent<CharacterDialogueTree>();
                            Transform probeAttention = SearchUtilities.Find("EyeOfTheUniverse_Body/Sector_EyeOfTheUniverse/Sector_Observatory/Interactables_Observatory/AttentionPoint_WarpCore").transform;
                            plaqueDialogueTree._attentionPoint = probeAttention;
                            plaqueDialogueTree._turnOffFlashlight = false;
                            plaqueDialogueTree._turnOnFlashlight = false;
                        }
                        GameObject plaqueLightGO = SearchUtilities.Find("ProbePlaque/PointLight_HEA_MuseumPlaque");
                        if (plaqueLightGO != null)
                        {
                            Light plaqueLight = plaqueLightGO.GetComponent<Light>();
                            plaqueLight.intensity = 1.5f;
                            plaqueLight.color = Color.cyan;
                        }
                        GameObject plaqueLightModel = SearchUtilities.Find("ProbePlaque/Props_HEA_MuseumPlaque_Geo/lantern_lamp");
                        if (plaqueLightModel != null)
                            plaqueLightModel.GetComponent<MeshRenderer>().material.color = Color.cyan;
                    }
                    else
                    {
                        if (plaque != null)
                            plaque.SetActive(false);
                        if (plaqueDialogue != null)
                            plaqueDialogue.SetActive(false);
                    }

                    //Make quantum states turn quantum on proximity
                    GameObject quantumProximityController = SearchUtilities.Find("QuantumProximityController");
                    GameObject quantumStates = SearchUtilities.Find("Quantum States - codex_eye_probe");
                    if (quantumProximityController != null && quantumStates != null)
                    {
                        ProximityQuantum proximityQuantum = quantumProximityController.AddComponent<ProximityQuantum>();
                        proximityQuantum.quantumStates = quantumStates.GetComponent<NewHorizons.Components.Quantum.NHMultiStateQuantumObject>();
                    }
                    else
                        ModHelper.Console.WriteLine("FAILED TO FIND QUANTUM PROXIMITY CONTROLLER OR QUANTUM STATES", MessageType.Error);

                    //Reparent final recorder
                    GameObject precursorRecorder = SearchUtilities.Find("EyeRecorderPrecursor");
                    GameObject precursorRecorderLocation = SearchUtilities.Find("PrecursorRecorderPosition");
                    if (precursorRecorder != null && precursorRecorderLocation != null)
                    {
                        precursorRecorder.transform.parent = precursorRecorderLocation.transform;
                        precursorRecorder.transform.localPosition = Vector3.zero;
                    }
                    else
                        ModHelper.Console.WriteLine("FAILED TO FIND PRECURSOR RECORDER OR ITS ANCHOR", MessageType.Error);
                }
            });
        }

        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            if (scene.name == "TitleScreen")
            {
                //Tesseract on title screen
                AssetBundle assetBundle = ModHelper.Assets.LoadBundle("planets/assets/astral_codex");
                GameObject titleTesseract = (GameObject) Instantiate(assetBundle.LoadAsset("Assets/Bundle/Tesseract.prefab"), new Vector3(-35, 100, -20), Quaternion.identity);
                titleTesseract.AddComponent<Tesseract>();
                assetBundle.Unload(false);
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
