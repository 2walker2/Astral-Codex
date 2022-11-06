using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;
using Harmony;
using System.Collections;

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
                "TranslationProbe2/Model",
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
                {"SpacecraftDetector", typeof(TechnologyWire) },
                {"Monolith", typeof(Monolith) },
                {"LingeringChime_Body/Sector/Water/WaterVolume", typeof(GhostMatterSubmerge) },
                {"PopulationScannerOrigin", typeof(PopulationTrails) },
                {"SpacecraftScannerOrigin", typeof(SpacecraftTrails) },
                {"Station/ProbeParticles", typeof(ProbeParticles) }
            };
            //Set scene loading
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            modHelper = ModHelper;
            ModHelper.Console.WriteLine($"TEST mod loaded", MessageType.Success);

            //Get New Horizons interface
            newHorizons = ModHelper.Interaction.TryGetModApi<INewHorizons>("xen.NewHorizons");
            newHorizons.LoadConfigs(this);

            //Setup
            newHorizons.GetStarSystemLoadedEvent().AddListener((string system) =>
            {
                if (system == "SolarSystem")
                {
                    //Debug
                    ModHelper.Console.WriteLine($"LISTENER ADDED", MessageType.Success);

                    //Assign ghost matter material
                    foreach (string ghostMatterCrystal in ghostMatterCrystals)
                    {
                        GameObject crystal = GameObject.Find(ghostMatterCrystal);
                        if (crystal != null)
                        {
                            crystal.AddComponent<GhostMatterMaterial>();
                            ModHelper.Console.WriteLine($"FOUND " + ghostMatterCrystal, MessageType.Success);
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
                                    ModHelper.Console.WriteLine($"FOUND MATERIAL " + pair.Value, MessageType.Success);
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

                    //Increase ghost matter damage
                    GameObject stationGhostMatter = GameObject.Find("StationGhostMatter");
                    stationGhostMatter.GetComponentInChildren<DarkMatterVolume>()._damagePerSecond = 150;


                    //Enable Ember tree collision
                    GameObject.Find("EmberTwinTree").GetComponentInChildren<MeshCollider>().enabled = true;

                    //Assign scripts
                    foreach (KeyValuePair<string, Type> pair in componentsToAdd)
                    {
                        GameObject obj = GameObject.Find(pair.Key);
                        if (obj != null)
                        {
                            obj.AddComponent(pair.Value);
                            ModHelper.Console.WriteLine($"FOUND " + pair.Key, MessageType.Success);
                        }
                        else
                            ModHelper.Console.WriteLine($"FAILED TO FIND " + pair.Key, MessageType.Error);
                    }

                    //Enable Lingering Chime reference frame
                    GameObject rfVolume = GameObject.Find("LingeringChime_Body").transform.GetChild(1).gameObject;
                    if (rfVolume != null)
                    {
                        ModHelper.Console.WriteLine("FOUND REFERENCE VOLUME", MessageType.Success);
                        rfVolume.SetActive(true);
                    }
                    else
                    {
                        ModHelper.Console.WriteLine("FAILED TO FIND REFERENCE VOLUME", MessageType.Error);
                    }

                    //Increase Timber Hearth shuttle radius
                    GameObject.Find("TimberHearth_Body/Sector_TH/Volumes_TH/RulesetVolumes_TH").GetComponent<PlanetoidRuleset>()._shuttleLandingRadius = 2000;

                    //Make sun cactus not cast shadows
                    GameObject sunCactus = GameObject.Find("Sun_Body/Sector_SUN/Prefab_HGT_Cactus_Single_A");
                    if (sunCactus != null)
                    {
                        ModHelper.Console.WriteLine("FOUND SUN CACTUS", MessageType.Success);
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
                        ModHelper.Console.WriteLine($"FOUND VISION STRUCTURE", MessageType.Success);
                        Destroy(visionStructure.GetComponentInChildren<MeshRenderer>());
                        Destroy(visionStructure.GetComponentInChildren<MeshCollider>());
                        Destroy(visionStructure.GetComponentInChildren<OWCollider>());
                    }
                    GameObject visionPool = GameObject.Find("StationVision/RemoteViewer_Pool");
                    if (visionPool != null)
                    {
                        ModHelper.Console.WriteLine($"FOUND VISION POOL", MessageType.Success);
                        visionPool.GetComponent<MeshFilter>().mesh = null;
                    }
                    GameObject visionPedestal = GameObject.Find("StationVision/PedestalAnchor/Prefab_NOM_SharedPedestal");
                    if (visionPedestal != null)
                    {
                        ModHelper.Console.WriteLine($"FOUND VISION PEDESTAL", MessageType.Success);
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
                    /*GameObject visionCamera = GameObject.Find("StationVision/RemoteViewerCamera");
                    if (visionCamera != null)
                    {
                        ModHelper.Console.WriteLine($"FOUND VISION CAMERA",MessageType.Success);
                        visionCamera.GetComponent<Camera>().cullingMask += (1 << 22);
                        //visionCamera.GetComponent<NomaiViewerImageEffect>()._material.color = new Color(0, 0, 0);
                    }*/
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
                        ModHelper.Console.WriteLine($"FOUND PROBE", MessageType.Success);
                        AssetBundle assetBundle = ModHelper.Assets.LoadBundle("planets/assets/astral_codex");
                        Instantiate(assetBundle.LoadAsset("Assets/Bundle/SignalParticles.prefab"), probe.transform);
                        AudioClip signal = (AudioClip)assetBundle.LoadAsset("Assets/Bundle/Audio/Signal.wav");
                        //Audio (doesn't work)
                        /*Destroy(probe.GetComponentInChildren<OWAudioSource>());
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
