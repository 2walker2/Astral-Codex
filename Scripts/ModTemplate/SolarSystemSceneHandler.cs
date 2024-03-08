using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.InputSystem;
using System.Diagnostics;

namespace AstralCodex
{
    //Configures the solar system scene
    class SolarSystemSceneHandler : MonoBehaviour
    {
        const string SceneName = "SolarSystem";

        #region Private Variables
        bool flashbackOverridden = false;
        NomaiExperimentBlackHole experimentBlackHole;
        TimeLoopCoreController timeLoopCoreController;
        GameObject skySphere;
        StarfieldController starfieldController;
        #endregion

        #region Path Lists
        //GameObjects to put on the VisibleToProbe layer and assign the ghost matter crystal material to
        List<string> ghostMatterCrystals = new List<string>() { 
            //"Station/Visual/Model",
            "BrambleScroll2/Props_NOM_Scroll/Props_NOM_Scroll_Geo",
            "TranslationCairn1",
            "TranslationCairn2",
            "TranslationCairn3",
            "TranslationCairn4",
            "TranslationCairn5",
            "TranslationCairn6",
            "TranslationCairn7",
            "InterloperRecorderWarning",
            "TranslationProbe1/ScaleRoot/Model",
            "TranslationProbe2/ScaleRoot/Model",
            "TranslationProbe3/Model",
            "Station/Visual/Model/Shell/Ghost Matter Shell",
            "CodexGalaxyComputer",
            "CodexSpeciesComputer",
            "CodexEnvironmentsComputer",
            "ChimeStatusComputer",
            "CodexCoreComputer",
            "CampfireSign",
            "CoresSign",
            "StaffSign",
            "DB_ExitOnlyDimension_Body/Sector_ExitOnlyDimension/Ernesto"
        };

        string exhaustName = "Exhaust";
        //Ghost matter exhaust gameObjects that should have the ghost matter material applied to all children named "Exhaust"
        List<string> ghostMatterExhaustObjects = new List<string>() {
            "Chime Exhaust Root",
            "Exterior Lidar Probes",
            "Interloper Thruster"
        };

        //Components to add to gameObjects in the scene
        Dictionary<string, Type> componentsToAdd = new Dictionary<string, Type>() {
            {"Tesseract", typeof(TesseractInteraction)},
            {"Sun Wires", typeof(SunWire)},
            {"Population Wires", typeof(PopulationWire) },
            {"Technology Wires", typeof(TechnologyWire) },
            {"TimberHearthSpacecraftDetector", typeof(SpacecraftDetector) },
            {"AshTwinSpacecraftDetector", typeof(SpacecraftDetector) },
            {"ChimeWhiteHoleWater/ChimeWhiteHoleWaterCollider", typeof(GhostMatterSubmerge) },
            {"PopulationScannerOrigin", typeof(PopulationTrails) },
            {"SpacecraftScannerOrigin", typeof(SpacecraftTrails) },
            {"ProbeParticles", typeof(ProbeParticles) },
            {"BrambleThornParticles", typeof(ThornParticles) },
            {"TranslationProbe2", typeof(EmberProjectionActivate) },
            {"Sector_CaveTwin/Railing 1", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 2", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 3", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 4", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 5", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 6", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 7", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 8", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 9", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 10", typeof(BoxCollider) },
            {"TranslationProbe1", typeof(BrambleProjectionActivate) },
            {"CodecDispenser/Core", typeof(CodexDispenser) },
            {"Trail Wires/Activation Trigger", typeof(TrailActivation) },
            {"Station/Volumes/HideMinimapVolume", typeof(HideMinimapTrigger) },
            {"BrambleWarpReceiver", typeof(DisableShapeInShip) },
            {"Sector_DB/Bramble Building/Transform Root/Warp Pad/Warp Pad Swivel", typeof(FaceBrambleSphere) },
        };

        Dictionary<string, Vector3> rotatingObjects = new Dictionary<string, Vector3>()
        {
            {"TranslationProbe2/ScaleRoot/Model/Projection Ring", new Vector3(0, 0, 2) },
            {"TranslationProbe2/ScaleRoot/Model/Projection Ring/Projections/Sun Scanner/ScanSource/SunScan", new Vector3(0, 8, 0) },
            {"TranslationProbe2/ScaleRoot/Model/Projection Ring/Projections/SpacecraftScanner/ScanSource (4)/DarkBramble", new Vector3(0, 8, 0) },
            {"TranslationProbe2/ScaleRoot/Model/Projection Ring/Projections/SpacecraftScanner/ScanSource (3)/GiantsDeep", new Vector3(0, 8, 0) },
            {"TranslationProbe2/ScaleRoot/Model/Projection Ring/Projections/SpacecraftScanner/ScanSource (2)/BrittleHollow", new Vector3(0, 8, 0) },
            {"TranslationProbe2/ScaleRoot/Model/Projection Ring/Projections/SpacecraftScanner/ScanSource (1)/TimberHearth", new Vector3(0, 8, 0) },
            {"TranslationProbe2/ScaleRoot/Model/Projection Ring/Projections/SpacecraftScanner/ScanSource/HourglassTwins", new Vector3(0, 8, 0) },
            {"TranslationProbe1/ScaleRoot/Model/HT Projector Ring", new Vector3(0, 0, -5) },
            {"TranslationProbe1/ScaleRoot/Model/TH Projector Ring", new Vector3(0, 0, -3) },
            {"TranslationProbe1/ScaleRoot/Model/BH Projector Ring", new Vector3(0, 0, -2.5f) },
            {"TranslationProbe1/ScaleRoot/Model/GD Projector Ring", new Vector3(0, 0, -2) },
            {"TranslationProbe1/ScaleRoot/Model/DB Projector Ring", new Vector3(0, 0, -1.5f) },
            {"TranslationProbe1/ScaleRoot/Model/Sun Projector/Sun Scanner/ScanSource/Sun", new Vector3(3, -3, 3) },
            {"TranslationProbe1/ScaleRoot/Model/HT Projector Ring/HT Scanner/ScanSource/Hourglass Twins", new Vector3(0, 10, 0) },
            {"TranslationProbe1/ScaleRoot/Model/TH Projector Ring/TH Scanner/ScanSource/TimberHearth", new Vector3(0, 10, 0) },
            {"TranslationProbe1/ScaleRoot/Model/BH Projector Ring/BH Scanner/ScanSource/Brittle Hollow", new Vector3(0, 10, 0) },
            {"TranslationProbe1/ScaleRoot/Model/GD Projector Ring/GD Scanner/ScanSource/Giant's Deep", new Vector3(0, 10, 0) },
            {"TranslationProbe1/ScaleRoot/Model/DB Projector Ring/DB Scanner/ScanSource/DarkBramble", new Vector3(0, 10, 0) },
            {"TranslationProbe1/Projections/Chime", new Vector3(0, -25, 0) },
            {"TranslationProbe1/Projections/Eye", new Vector3(0, 10, 0) },
            //Chime
            {"Station/Solar Panels", new Vector3(0, 0, 10) },
            {"Station/Orbiting Water Root", new Vector3(0, 3, 0) },
            {"Station/Exterior Lidar Probes", new Vector3(0, 1.5f, 0) },
            {"Station/Exterior Lidar Probes/Probe Root/Probe/Model", new Vector3(0, 0, -10) },
            {"Station/Exterior Lidar Probes/Probe Root (1)/Probe/Model", new Vector3(0, 0, -10) },
            {"Station/Exterior Lidar Probes/Probe Root (2)/Probe/Model", new Vector3(0, 0, -10) },
            {"Station/Exterior Lidar Probes/Probe Root (3)/Probe/Model", new Vector3(0, 0, -10) },
            {"Station/Props/Transmitter/Transmitter Orb", new Vector3(0, 0, 15) },
            {"Station/Visual/Upper Central Platform/Eye", new Vector3(0, 1.5f, 0) },
            {"Station/Visual/Lower Central Platform/Eye", new Vector3(0, 1.5f, 0) },
            {"Station/Black Hole Water/BlackHoleWarpCoreRoot", new Vector3(0, 10, 0) },
            {"Station/Black Hole Water/BlackHoleWarpCoreRoot/BlackHoleWarpCorePosittion", new Vector3(-30, 0, 0) },
            {"Station/Orbiting Water Root/ChimeWhiteHoleWater/White Hole/WhiteHoleWarpCoreRoot", new Vector3(0, 15, 0) },
            {"Station/Orbiting Water Root/ChimeWhiteHoleWater/White Hole/WhiteHoleWarpCoreRoot/WhiteHoleWarpCorePosition", new Vector3(-30, 0, 0) },
            {"Station/Props/Staff Crystal/Staff", new Vector3(0, 15, 0) },
            {"Station/Spacecraft Area/Scanner/Orb", new Vector3(100, 0, 0) },
            {"Station/Population Area/Scanner/Orb", new Vector3(100, 0, 0) },
            {"Station/CodecDispenser/Model/Reflectors", new Vector3(0, 0, 3) },
            {"Station/CodecDispenser/Model/Canisters", new Vector3(0, 0, -3) },
            {"Station/Props/Projector Model Sun/Projector_Fin/Head", new Vector3(0, 100, 0) },
            {"Station/Props/Projector Model Population/Projector_Fin/Head", new Vector3(0, 100, 0) },
            {"Station/Props/Projector Model Spacecraft/Projector_Fin/Head", new Vector3(0, 100, 0) }
        };

        List<string> visibleToProbeChimeProps = new List<string>()
        {
            "StationClutter1",
            "StationClutter2",
            "StationClutter3",
            "StationClutter4",
            "ArchivedCampfire",
            "WhiteHoleWarpCore",
            "BlackHoleWarpCore"
        };
        #endregion

        #region Initialization
        void Awake()
        {
            //Initialize the star system loaded callback
            Main.newHorizons.GetStarSystemLoadedEvent().AddListener((string system) => { OnStarSystemLoaded(system); });
        }
        #endregion

        #region Star System Loaded Callback
        void OnStarSystemLoaded(string system)
        {
            if (system == SceneName)
            {
                AssetHandler.S.Load();

                flashbackOverridden = false;

                //General configuration
                AssignGhostMatterMaterial();
                AssignGhostMatterExhaustMaterial();
                AssignScripts();
                AssignRotatingObjects();

                //Specific configurations
                HideFlashbackSlides();
                ConfigureSkybox();
                IncreaseGhostMatterDamage();
                EnableEmberTreeCollision();
                InitializeSpacetimeStabilitySystem();
                RemoveBreakableComponentFromBramblePlatforms();
                RemoveSubmergeControllerFromBrambleGhostMatter();
                ConfigureBrambleWarpPads();
                MakeBrambleCloakSphereCastShadows();
                
                //Chime configuration
                ConfigureChime();

                //Music configuration
                NewHorizons.Utility.OWML.Delay.FireOnNextUpdate(MusicHandler.Initialize);
                if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
                    NewHorizons.Utility.OWML.Delay.FireOnNextUpdate(MusicHandler.SetFinalEndTimes);
            }
        }
        #endregion

        #region General Configuration
        void AssignGhostMatterMaterial()
        {
            //Assign ghost matter material to objects in the scene
            foreach (string ghostMatterCrystal in ghostMatterCrystals)
            {
                GameObject crystal = GameObject.Find(ghostMatterCrystal);
                if (crystal != null)
                {
                    crystal.AddComponent<GhostMatterMaterial>();
                    //Main.modHelper.Console.WriteLine($"FOUND " + ghostMatterCrystal, MessageType.Success);
                }
            }
        }

        void AssignGhostMatterExhaustMaterial()
        {
            //Assign ghost matter material to objects in the scene
            foreach (string ghostMatterExhaust in ghostMatterExhaustObjects)
            {
                GameObject ghostMatterExhaustGO = SearchUtilities.Find(ghostMatterExhaust);
                if (ghostMatterExhaustGO != null)
                {
                    MeshRenderer[] exhaustRenderers = ghostMatterExhaustGO.GetComponentsInChildren<MeshRenderer>();
                    foreach (MeshRenderer exhaustRenderer in exhaustRenderers)
                    {
                        if (exhaustRenderer.gameObject.name == exhaustName)
                            exhaustRenderer.material = AssetHandler.materials["ghostMatter"];
                    }
                }
                else
                    Main.modHelper.Console.WriteLine("FAILED TO FIND GHOST MATTER EXHAUST ROOT " + ghostMatterExhaust);
            }
        }

        void AssignScripts()
        {
            //Assign scripts to objects in the scene
            foreach (KeyValuePair<string, Type> pair in componentsToAdd)
            {
                GameObject obj = SearchUtilities.Find(pair.Key);
                if (obj != null)
                {
                    obj.AddComponent(pair.Value);
                    //Main.modHelper.Console.WriteLine($"FOUND " + pair.Key, MessageType.Success);
                }
                else
                    Main.modHelper.Console.WriteLine($"FAILED TO FIND " + pair.Key, MessageType.Error);
            }
        }

        void AssignRotatingObjects()
        {
            //Add a Rotate component to objects that should rotate
            foreach (KeyValuePair<string, Vector3> pair in rotatingObjects)
            {
                GameObject obj = SearchUtilities.Find(pair.Key);
                if (obj != null)
                {
                    Rotate added = obj.AddComponent<Rotate>();
                    added.speed = pair.Value;
                    //Main.modHelper.Console.WriteLine($"FOUND ROTATING OBJECT " + pair.Key, MessageType.Success);
                }
                else
                    Main.modHelper.Console.WriteLine($"FAILED TO FIND ROTATING OBJECT " + pair.Key, MessageType.Error);
            }
        }
        #endregion

        #region Specific Configuration
        void HideFlashbackSlides()
        {
            //Hide the flashback slides on TH used to generate the flashback ship log
            GameObject flashbackSlides = SearchUtilities.Find("FlashbackSlides");
            if (flashbackSlides != null)
            {
                flashbackSlides.transform.GetChild(0).gameObject.SetActive(false);
                flashbackSlides.GetComponent<SphereCollider>().enabled = false;
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND FLASHBACK SLIDES", MessageType.Error);
        }

        void ConfigureSkybox()
        {
            //Replace skybox material with a transparent version so the default stars are still visible
            skySphere = SearchUtilities.Find("Skybox/Sky Sphere");
            if (skySphere != null)
            {
                for (int i = 0; i < skySphere.transform.childCount; i++)
                {
                    MeshRenderer renderer = skySphere.transform.GetChild(i).GetComponent<MeshRenderer>();
                    renderer.material = AssetHandler.skyboxMaterialList[i];
                }
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND SKY SPHERE", MessageType.Error);

            starfieldController = FindObjectOfType<StarfieldController>();
        }

        void IncreaseGhostMatterDamage()
        {
            //Increase the damage of ghost matter patches to prevent the player from speeding through them
            //Chime ghost matter
            GameObject stationGhostMatter = GameObject.Find("StationGhostMatter");
            if (stationGhostMatter != null)
                stationGhostMatter.GetComponent<DarkMatterVolume>()._damagePerSecond = 150;
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND STATION GHOST MATTER", MessageType.Error);

            //Bramble ghost matter
            GameObject brambleGhostMatter = GameObject.Find("BrambleGhostMatter");
            if (brambleGhostMatter != null)
                brambleGhostMatter.GetComponentInChildren<DarkMatterVolume>()._damagePerSecond = 150;
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND BRAMBLE GHOST MATTER", MessageType.Error);
        }

        void EnableEmberTreeCollision()
        {
            //Enable collision on the reunion memorial tree on ET
            GameObject.Find("EmberTwinTree").GetComponentInChildren<MeshCollider>().enabled = true;
        }

        void InitializeSpacetimeStabilitySystem()
        {
            //Initialize the spacetime stability system
            GameObject experimentBlackHoleGO = SearchUtilities.Find("CaveTwin_Body/Sector_CaveTwin/Sector_NorthHemisphere/Sector_NorthSurface/Sector_TimeLoopExperiment/Interactables_TimeLoopExperiment/WarpCoreExperiment/SingularityEffects/Singularity_BlackHole");
            if (experimentBlackHoleGO != null)
                experimentBlackHole = experimentBlackHoleGO.GetComponent<NomaiExperimentBlackHole>();
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND EXPERIMENT BLACK HOLE", MessageType.Error);

            timeLoopCoreController = FindObjectOfType<TimeLoopCoreController>();
            if (timeLoopCoreController == null)
                Main.modHelper.Console.WriteLine("FAILED TO FIND TIME LOOP CORE CONTROLLER", MessageType.Error);
        }

        void RemoveBreakableComponentFromBramblePlatforms()
        {
            GameObject brambleSector = SearchUtilities.Find("DarkBramble_Body/Sector_DB");
            //Fragment integrity components
            FragmentIntegrity[] fragmentIntegrities = brambleSector.GetComponentsInChildren<FragmentIntegrity>();
            foreach (FragmentIntegrity fragmentIntegrity in fragmentIntegrities)
                Destroy(fragmentIntegrity);
            //Detechable fragment components
            DetachableFragment[] detachableFragments = brambleSector.GetComponentsInChildren<DetachableFragment>();
            foreach (DetachableFragment detachableFragment in detachableFragments)
                Destroy(detachableFragment);
        }

        void RemoveSubmergeControllerFromBrambleGhostMatter()
        {
            Destroy(SearchUtilities.Find("BrambleGhostMatter").GetComponent<DarkMatterSubmergeController>());
        }

        void ConfigureBrambleWarpPads()
        {
            NomaiWarpTransmitter warpTransmitter = SearchUtilities.Find("BrambleWarpTransmitter").GetComponent<NomaiWarpTransmitter>();
            warpTransmitter._warpRadius = 5;
            NomaiWarpReceiver warpReceived = SearchUtilities.Find("BrambleWarpReceiver").GetComponent<NomaiWarpReceiver>();
            warpReceived._warpRadius = 5;
        }

        void MakeBrambleCloakSphereCastShadows()
        {
            MeshRenderer brambleCloakSphereRenderer = SearchUtilities.Find("DB_HubDimension_Body/BrambleRepelVolume/CloakSphere").GetComponent<MeshRenderer>();
            brambleCloakSphereRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        }
        #endregion

        #region Chime Configuration
        void ConfigureChime()
        {
            //Configure gameObjects in the Lingering Chime
            ApplyChimeMaterials();
            ParentChimeWaterToWhiteHole();
            MakeChimeSignalDetectableUnderwater();
            PutChimePropsOnVisibleToProbeLayer();
            EnableChimeReferenceFrame();
            ConfigureProjectionPool();
            RandomizeWindChimeAnimationTime();
            ReduceAudioRangeOfSingularities();
        }

        void ApplyChimeMaterials()
        {
            //Apply ghost matter crystal material to shell
            GameObject chimeShell = SearchUtilities.Find("Visual/Shell/Crystal");
            if (chimeShell != null)
            {
                chimeShell.GetComponent<MeshRenderer>().material = AssetHandler.materials["ghostMatterCrystal"];
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND CHIME SHELL");

            //Apply ghost matter crystal material to cracked geode interior
            GameObject crackedGeode = SearchUtilities.Find("Visual/Rotatable/Cracked Geode");
            if (crackedGeode != null)
            {
                MeshRenderer crackedGeodeRenderer = crackedGeode.GetComponent<MeshRenderer>();
                Material[] crackedGeodeMaterials = crackedGeodeRenderer.materials;
                crackedGeodeMaterials[1] = AssetHandler.materials["ghostMatterCrystal"];
                crackedGeodeRenderer.materials = crackedGeodeMaterials;
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND CRACKED GEODE");

            //Apply sand material to terrain
            GameObject chimeTerrain = SearchUtilities.Find("Visual/Interior Terrain/Terrain");
            if (chimeTerrain != null)
            {
                MeshRenderer terrainRenderer = chimeTerrain.GetComponent<MeshRenderer>();
                terrainRenderer.material = AssetHandler.materials["sand"];
                terrainRenderer.material.color = Color.black;
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND CHIME TERRAIN");
        }

        void ParentChimeWaterToWhiteHole()
        {
            //Parent Chime water to white hole
            GameObject chimeWater = SearchUtilities.Find("LingeringChime_Body/Sector/Water");
            if (chimeWater != null)
            {
                GameObject chimeWhiteHoleWater = SearchUtilities.Find("Station/Orbiting Water Root/ChimeWhiteHoleWater");
                if (chimeWhiteHoleWater != null)
                {
                    chimeWater.transform.parent = chimeWhiteHoleWater.transform;
                    chimeWater.transform.localPosition = Vector3.zero;

                    //Also update layer for lighting
                    chimeWater.layer = 4; //"Water" layer
                }
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND CHIME WATER", MessageType.Error);
        }

        void MakeChimeSignalDetectableUnderwater()
        {
            //Make Chime signal detectable underwater
            GameObject chimeSignal = SearchUtilities.Find("Chime Signal");
            if (chimeSignal != null)
            {
                AudioSignalDetectionTrigger detectionTrigger = chimeSignal.GetComponent<AudioSignalDetectionTrigger>();
                detectionTrigger._allowUnderwater = true;
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND CHIME SIGNAL", MessageType.Error);
        }

        void PutChimePropsOnVisibleToProbeLayer()
        {
            //Put Chime clutter on VisibleToProbe (22) layer
            foreach (string prop in visibleToProbeChimeProps)
            {
                GameObject propGO = SearchUtilities.Find(prop);
                if (propGO != null)
                {
                    Renderer[] propRenderers = propGO.GetComponentsInChildren<Renderer>();
                    foreach (Renderer renderer in propRenderers)
                        renderer.gameObject.layer = 22;
                }
                    
                else
                    Main.modHelper.Console.WriteLine("FAILED TO FIND CHIME PROP "+prop, MessageType.Error);
            }
        }

        void EnableChimeReferenceFrame()
        {
            //Enable the reference frame on the Lingering Chime
            GameObject rfVolume = GameObject.Find("LingeringChime_Body").transform.GetChild(1).gameObject;
            if (rfVolume != null)
            {
                //Main.modHelper.Console.WriteLine("FOUND REFERENCE VOLUME", MessageType.Success);
                rfVolume.SetActive(true);
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND REFERENCE VOLUME", MessageType.Error);
        }

        void ConfigureProjectionPool()
        {
            //Configure the invisible projection pool used for the secondary probe recording
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
                //Main.modHelper.Console.WriteLine($"FOUND PROJECTION STRUCTURE", MessageType.Success);
                Destroy(visionStructure.GetComponentInChildren<MeshRenderer>());
                Destroy(visionStructure.GetComponentInChildren<MeshCollider>());
                Destroy(visionStructure.GetComponentInChildren<OWCollider>());
            }
            GameObject visionPool = GameObject.Find("StationVision/RemoteViewer_Pool");
            if (visionPool != null)
            {
                //Main.modHelper.Console.WriteLine($"FOUND PROJECTION POOL", MessageType.Success);
                visionPool.GetComponent<MeshFilter>().mesh = null;
            }
            GameObject visionPedestal = GameObject.Find("StationVision/PedestalAnchor/Prefab_NOM_SharedPedestal");
            if (visionPedestal != null)
            {
                //Main.modHelper.Console.WriteLine($"FOUND PROJECTION PEDESTAL", MessageType.Success);
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
                //Main.modHelper.Console.WriteLine($"FOUND PROJECTION CAMERA",MessageType.Success);
                visionCamera.GetComponent<Camera>().cullingMask += (1 << 22);
                //visionCamera.GetComponent<NomaiViewerImageEffect>()._material.color = new Color(0, 0, 0);
            }*/
        }

        GameObject windChimeRoot;
        void RandomizeWindChimeAnimationTime()
        {
            foreach (Animator animator in SearchUtilities.Find("Station/Wind Chimes").GetComponentsInChildren<Animator>())
            {
                animator.Play("WindChime", -1, UnityEngine.Random.Range(0.0f, 1.0f));
            }
        }

        void ReduceAudioRangeOfSingularities()
        {
            GameObject blackHoleAmbiance = SearchUtilities.Find("codex_chime_black/BlackHoleAmbience");
            blackHoleAmbiance.GetComponent<AudioSource>().maxDistance = 10;
            GameObject whiteHoleAmbiance = SearchUtilities.Find("codex_chime_white/BlackHoleAmbience");
            whiteHoleAmbiance.GetComponent<AudioSource>().maxDistance = 10;
        }
        #endregion

        #region Update
        void Update()
        {
            if (SceneManager.GetSceneByName(SceneName).isLoaded)
            {
                //Player death management
                if (Locator.GetDeathManager().IsPlayerDying())
                {
                    PlayerDeathHandler();
                }

                StabilizeSpacetime();
                PreventSkyboxInDreamWorld();

                if (Main.debugMode)
                    DebugUtilities();
            }
        }
        #endregion

        #region Update Functions
        void PlayerDeathHandler()
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
                        RenderTexture[] flashbackTextureArray = new RenderTexture[AssetHandler.flashbackTextureList.Count];
                        for (int i = 0; i < AssetHandler.flashbackTextureList.Count; i++)
                        {
                            flashbackTextureArray[i] = new RenderTexture(480, 270, 0);
                            flashbackTextureArray[i].enableRandomWrite = true;
                            Graphics.CopyTexture(AssetHandler.flashbackTextureList[i], flashbackTextureArray[i]);
                        }
                        flashbackRecorder._renderTextureArray = flashbackTextureArray;
                        flashbackRecorder._numCapturedSnapshots = flashbackTextureArray.Length;

                        GameObject flashbackScreen = SearchUtilities.Find("FlashbackCamera/Screen");
                        if (flashbackScreen != null)
                            flashbackScreen.GetComponent<MeshRenderer>().material = AssetHandler.materials["spritesDefault"];
                        else
                            Main.modHelper.Console.WriteLine("FAILED TO FIND FLASHBACK SCREEN", MessageType.Error);
                    }
                    else
                        Main.modHelper.Console.WriteLine("FAILED TO FIND FLASHBACK CAMERA", MessageType.Error);
                }
                flashbackOverridden = true;
            }

            //Prevent probe from duplicating in ATP
            if (PlayerData.GetPersistentCondition("CODEX_ENTERED_TESSERACT"))
                PlayerData.SetPersistentCondition("PROBE_ENTERED_TIMELOOPCORE", false);
        }

        void StabilizeSpacetime()
        {
            //Prevent spacetime from breaking
            if (TimeLoopCoreController.s_paradoxExists || (experimentBlackHole!= null && experimentBlackHole._duplicateActive))
            {
                if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_lingering_chime_tesseract") && PlayerData._currentGameSave.shipLogFactSaves["codex_lingering_chime_tesseract"].revealOrder > -1)
                {
                    TimeLoopCoreController.s_paradoxExists = false; //Prevent from breaking via ATP duplication
                    EyeStateManager.s_paradoxExists = false; //Prevent from breaking while at Eye
                    experimentBlackHole._duplicateActive = false; //Prevent from breaking via HEL experiment
                    timeLoopCoreController._probeEnteredCoreLastLoop = false; //Prevent from breaking if probe is sent through ATP
                    timeLoopCoreController._playerEnteredCoreLastLoop = false; //Prevent from breaking in edge cases if player is sent through ATP
                }
            }
        }

        void PreventSkyboxInDreamWorld()
        {
            if (PlayerData.GetPersistentCondition("CODEX_ENTERED_TESSERACT"))
            {
                if (skySphere.activeSelf && starfieldController._playerInDreamWorld)
                    skySphere.SetActive(false);
                else if (!skySphere.activeSelf && !starfieldController._playerInDreamWorld)
                    skySphere.SetActive(true);
            }
        }

        void DebugUtilities()
        {
            if (Keyboard.current.lKey.isPressed)
            {
                //Debug warp to Chime
                if (Keyboard.current.cKey.wasPressedThisFrame)
                {
                    OWRigidbody playerBody = Locator.GetPlayerBody();
                    if (playerBody != null)
                    {
                        playerBody.SetPosition(Locator.GetSunTransform().position + new Vector3(3, -35010, 0));
                        playerBody.SetVelocity(Vector3.zero);
                        playerBody.SetAngularVelocity(Vector3.zero);
                    }
                }
                else if (Keyboard.current.sKey.wasPressedThisFrame)
                {
                    GameObject sunLight = SearchUtilities.Find("SunLight");
                    sunLight.SetActive(!sunLight.activeSelf);
                }
            }
            else if (Keyboard.current.zKey.wasPressedThisFrame)
            {
                if (Time.timeScale > 0)
                    Time.timeScale = 0;
                else
                    Time.timeScale = 1;
            }
        }
        #endregion
    }
}
