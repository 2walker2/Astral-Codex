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
using Harmony;

namespace AstralCodex
{
    //Configures the solar system scene
    class SolarSystemSceneHandler : MonoBehaviour
    {
        const string SceneName = "SolarSystem";

        #region Private Variables
        bool flashbackOverridden = false;
        NomaiExperimentBlackHole experimentBlackHole;
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
            //"InterloperRecorderBreach",
            "InterloperRecorderWarning",
            "TranslationProbe1/ScaleRoot/Model",
            "TranslationProbe2/ScaleRoot/Model",
            "TranslationProbe3/Model",
            //"ChimeSign",
            "Station/Visual/Model/Shell/Ghost Matter Shell",
            "CodexGalaxyComputer",
            "CodexSpeciesComputer",
            "CodexEnvironmentsComputer"
        };

        //Components to add to gameObjects in the scene
        Dictionary<string, Type> componentsToAdd = new Dictionary<string, Type>() {
            {"Tesseract", typeof(TesseractInteraction)},
            {"Sun Wires", typeof(SunWire)},
            { "Population Wires", typeof(PopulationWire) },
            { "Technology Wires", typeof(TechnologyWire) },
            { "TimberHearthSpacecraftDetector", typeof(SpacecraftDetector) },
            { "AshTwinSpacecraftDetector", typeof(SpacecraftDetector) },
            { "ChimeWhiteHoleWater/ChimeWhiteHoleWaterCollider", typeof(GhostMatterSubmerge) },
            { "PopulationScannerOrigin", typeof(PopulationTrails) },
            { "SpacecraftScannerOrigin", typeof(SpacecraftTrails) },
            { "ProbeParticles", typeof(ProbeParticles) },
            { "BrambleThornParticles", typeof(ThornParticles) },
            { "TranslationProbe2", typeof(EmberProjectionActivate) },
            { "Sector_CaveTwin/Railing 1", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 2", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 3", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 4", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 5", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 6", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 7", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 8", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 9", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 10", typeof(BoxCollider) },
            { "TranslationProbe1", typeof(BrambleProjectionActivate) },
            { "CodecDispenser/Core/Collision", typeof(CodexDispenser) },
            { "Trail Wires/Activation Trigger", typeof(TrailActivation) }
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
            {"TranslationProbe1/ScaleRoot/Model/HT Projector Ring", new Vector3(0, 0, 5) },
            {"TranslationProbe1/ScaleRoot/Model/TH Projector Ring", new Vector3(0, 0, 3) },
            {"TranslationProbe1/ScaleRoot/Model/BH Projector Ring", new Vector3(0, 0, 2.5f) },
            {"TranslationProbe1/ScaleRoot/Model/GD Projector Ring", new Vector3(0, 0, 2) },
            {"TranslationProbe1/ScaleRoot/Model/DB Projector Ring", new Vector3(0, 0, 1.5f) },
            {"TranslationProbe1/ScaleRoot/Model/Sun Projector/Sun Scanner/ScanSource/Sun", new Vector3(3, -3, 3) },
            {"TranslationProbe1/ScaleRoot/Model/HT Projector Ring/HT Scanner/ScanSource/Hourglass Twins", new Vector3(0, 10, 0) },
            {"TranslationProbe1/ScaleRoot/Model/TH Projector Ring/TH Scanner/ScanSource/TimberHearth", new Vector3(0, 10, 0) },
            {"TranslationProbe1/ScaleRoot/Model/BH Projector Ring/BH Scanner/ScanSource/Brittle Hollow", new Vector3(0, 10, 0) },
            {"TranslationProbe1/ScaleRoot/Model/GD Projector Ring/GD Scanner/ScanSource/Giant's Deep", new Vector3(0, 10, 0) },
            {"TranslationProbe1/ScaleRoot/Model/DB Projector Ring/DB Scanner/ScanSource/DarkBramble", new Vector3(0, 10, 0) },
            {"TranslationProbe1/Projections/TravelLine/Chime", new Vector3(0, -25, 0) },
            {"TranslationProbe1/Projections/TravelLine/Eye", new Vector3(0, 10, 0) },
            //Chime
            {"Station/Visual/Solar Panels", new Vector3(0, 0, 10) },
            {"Station/Collision/Solar Panels", new Vector3(0, 0, 10) },
            {"Station/Orbiting Water Root", new Vector3(0, 3, 0) },
            {"Station/Transmitter Coin/Root/Codex Environments Projection/Scanner/Scan Source", new Vector3(0, 15, 0)},
            {"Station/Campfire Coin/Root/Codex Species Projection/Scanner", new Vector3(0, 5, 0)},
            {"Station/Other Coin/Root/Codex Galaxy Projection/ScanSource/Dot Emitter", new Vector3(0, 5, 0)},
            {"Station/Exterior Lidar Probes", new Vector3(0, 1.5f, 0) },
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
                AssignScripts();
                AssignRotatingObjects();

                //Specific configurations
                HideFlashbackSlides();
                ReplaceSkyboxMaterial();
                IncreaseGhostMatterDamage();
                EnableEmberTreeCollision();
                InitializeSpacetimeStabilitySystem();

                NewHorizons.Utility.OWML.Delay.FireOnNextUpdate(SwitchFinalEndTimesMusic);
                
                //Chime configuration
                ConfigureChime();
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

        void ReplaceSkyboxMaterial()
        {
            //Replace skybox material with a transparent version so the default stars are still visible
            GameObject skySphere = SearchUtilities.Find("Skybox/Sky Sphere");
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
        }

        void SwitchFinalEndTimesMusic()
        {
            //Switch the final end times audio if the player has the codec at the start of the loop
            if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
            {
                GlobalMusicController globalMusicController = Locator.GetGlobalMusicController();

                //Override settings on all final end times sources
                globalMusicController._finalEndTimesIntroSource._audioLibraryClip = 0;
                globalMusicController._finalEndTimesIntroSource._clipArrayIndex = 0;
                globalMusicController._finalEndTimesIntroSource._clipArrayLength = 0;
                globalMusicController._finalEndTimesIntroSource._clipSelectionOnPlay = OWAudioSource.ClipSelectionOnPlay.MANUAL;

                globalMusicController._finalEndTimesLoopSource._audioLibraryClip = 0;
                globalMusicController._finalEndTimesLoopSource._clipArrayIndex = 0;
                globalMusicController._finalEndTimesLoopSource._clipArrayLength = 0;
                globalMusicController._finalEndTimesLoopSource._clipSelectionOnPlay = OWAudioSource.ClipSelectionOnPlay.MANUAL;

                globalMusicController._finalEndTimesDarkBrambleSource._audioLibraryClip = 0;
                globalMusicController._finalEndTimesDarkBrambleSource._clipArrayIndex = 0;
                globalMusicController._finalEndTimesDarkBrambleSource._clipArrayLength = 0;
                globalMusicController._finalEndTimesDarkBrambleSource._clipSelectionOnPlay = OWAudioSource.ClipSelectionOnPlay.MANUAL;

                //Switch the clips
                AudioClip codecFinalEndTimes = AssetHandler.audioClips["codecFinalEndTimes"];
                globalMusicController._finalEndTimesIntroSource.clip = codecFinalEndTimes;
                globalMusicController._finalEndTimesLoopSource.clip = codecFinalEndTimes;
                globalMusicController._finalEndTimesDarkBrambleSource.clip = codecFinalEndTimes;
            }
        }
        #endregion

        #region Chime Configuration
        void ConfigureChime()
        {
            //Configure gameObjects in the Lingering Chime
            ApplyChimeMaterials();
            ParentChimeWaterToWhiteHole();
            MakeChimeSignalDetectableUnderwater();
            PutChimeClutterOnVisibleToProbeLayer();
            EnableChimeReferenceFrame();
            ConfigureProjectionPool();
        }

        void ApplyChimeMaterials()
        {
            //Apply ghost matter material to Chime exhaust
            GameObject chimeExhaust = SearchUtilities.Find("Chime Exhaust Root");
            if (chimeExhaust != null)
            {
                foreach (MeshRenderer renderer in chimeExhaust.GetComponentsInChildren<MeshRenderer>())
                {
                    renderer.material = AssetHandler.materials["ghostMatter"];
                }
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND CHIME EXHAUST ROOT");

            //Apply ghost matter material to lidar probe Chime exhaust
            GameObject lidarProbesRoot = SearchUtilities.Find("Exterior Lidar Probes");
            if (lidarProbesRoot != null)
            {
                foreach (MeshRenderer renderer in lidarProbesRoot.GetComponentsInChildren<MeshRenderer>())
                {
                    if (renderer.gameObject.name == "Exhaust")
                        renderer.material = AssetHandler.materials["ghostMatter"];
                }
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND EXTERIOR LIDAR PROBES ROOT");

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

        void PutChimeClutterOnVisibleToProbeLayer()
        {
            //Put Chime clutter on VisibleToProbe (22) layer
            GameObject stationClutter1 = SearchUtilities.Find("StationClutter1");
            if (stationClutter1 != null)
            {
                stationClutter1.layer = 22;
                SearchUtilities.Find("StationClutter2").layer = 22;
                SearchUtilities.Find("StationClutter3").layer = 22;
                SearchUtilities.Find("StationClutter4").layer = 22;
                //SearchUtilities.Find("StationClutter5").layer = 22;
                //SearchUtilities.Find("StationClutter6").layer = 22;
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND STATION CLUTTER");
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
        }

        void StabilizeSpacetime()
        {
            //Prevent spacetime from breaking
            if (TimeLoopCoreController.s_paradoxExists || (experimentBlackHole!= null && experimentBlackHole._duplicateActive))
            {
                if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_lingering_chime_tesseract") && PlayerData._currentGameSave.shipLogFactSaves["codex_lingering_chime_tesseract"].revealOrder > -1)
                {
                    TimeLoopCoreController.s_paradoxExists = false; //Prevent from breaking via ATP duplication
                    experimentBlackHole._duplicateActive = false; //Prevent from breaking via HEL experiment
                }
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
                        playerBody.SetPosition(Locator.GetSunTransform().position + new Vector3(0, -34998, 0));
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
        }
        #endregion
    }
}
