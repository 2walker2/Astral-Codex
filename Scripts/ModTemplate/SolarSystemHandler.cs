using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;
using UnityEngine.SceneManagement;
using System;

namespace AstralCodex
{
    //Configures the solar system scene
    class SolarSystemHandler : MonoBehaviour
    {
        const string SceneName = "SolarSystem";

        #region Public Variables
        //Asset references
        public Dictionary<string, Material> materials;
        public Dictionary<string, AudioClip> audioClips;
        #endregion

        #region Path List Declarations
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
            "Station Redesign v2/Visual/Model/Shell/Ghost Matter Shell",
            "CodexGalaxyComputer",
            "CodexSpeciesComputer",
            "CodexEnvironmentsComputer"
        };

        //Materials to find on the asset references prefab
        Dictionary<string, string> materialsToFind = new Dictionary<string, string>()
        {
            {"RedReference", "red"},
            {"GreenReference", "green" },
            {"LightReference", "light" },
            {"BlackReference", "black" },
            {"SpritesDefaultReference", "spritesDefault" }
        };

        //AudioClips to find on the asset references prefab
        Dictionary<string, string> audioClipsToFind = new Dictionary<string, string>()
        {
            {"TravelMusicReference", "fourDTravelMusic"}
        };

        //Components to add to gameObjects in the scene
        Dictionary<string, Type> componentsToAdd = new Dictionary<string, Type>() {
            {"Tesseract", typeof(Tesseract)},
            {"SunWire", typeof(SunWire)},
            { "PopulationWire", typeof(PopulationWire) },
            { "TechnologyWire", typeof(TechnologyWire) },
            { "TimberHearthSpacecraftDetector", typeof(SpacecraftDetector) },
            { "AshTwinSpacecraftDetector", typeof(SpacecraftDetector) },
            //{"Monolith", typeof(Monolith) },
            { "ChimeWhiteHoleWater/ChimeWhiteHoleWaterCollider", typeof(GhostMatterSubmerge) },
            { "PopulationScannerOrigin", typeof(PopulationTrails) },
            { "SpacecraftScannerOrigin", typeof(SpacecraftTrails) },
            { "ProbeParticles", typeof(ProbeParticles) },
            { "BrambleThornParticles", typeof(ThornParticles) },
            { "TranslationProbe2", typeof(EmberProjectionActivate) },
            { "Sector_CaveTwin/Railing 1", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 2", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 3", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 4", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 5", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 6", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 7", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 8", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 9", typeof(BoxCollider) }, { "Sector_CaveTwin/Railing 10", typeof(BoxCollider) },
            { "TranslationProbe1", typeof(BrambleProjectionActivate) },
        };

        Dictionary<string, Vector3> rotatingObjects = new Dictionary<string, Vector3>()
        {
            {"TranslationProbe2/Projections", new Vector3(0, 2, 0) },
            {"TranslationProbe2/Projections/Sun Scanner/ScanSource/SunScan", new Vector3(0, 8, 0) },
            {"TranslationProbe2/Projections/SpacecraftScanner/ScanSource (4)/DarkBramble", new Vector3(0, 8, 0) },
            {"TranslationProbe2/Projections/SpacecraftScanner/ScanSource (3)/GiantsDeep", new Vector3(0, 8, 0) },
            {"TranslationProbe2/Projections/SpacecraftScanner/ScanSource (2)/BrittleHollow", new Vector3(0, 8, 0) },
            {"TranslationProbe2/Projections/SpacecraftScanner/ScanSource (1)/TimberHearth", new Vector3(0, 8, 0) },
            {"TranslationProbe2/Projections/SpacecraftScanner/ScanSource/HourglassTwins", new Vector3(0, 8, 0) },
            {"TranslationProbe1/Projections/HT Scanner", new Vector3(0, 5, 0) },
            {"TranslationProbe1/Projections/TH Scanner", new Vector3(0, 3, 0) },
            {"TranslationProbe1/Projections/BH Scanner", new Vector3(0, 2.5f, 0) },
            {"TranslationProbe1/Projections/GD Scanner", new Vector3(0, 2, 0) },
            {"TranslationProbe1/Projections/DB Scanner", new Vector3(0, 1.5f, 0) },
            {"TranslationProbe1/Projections/Sun Scanner/ScanSource/Sun", new Vector3(3, -3, 3) },
            {"TranslationProbe1/Projections/HT Scanner/ScanSource/Hourglass Twins", new Vector3(0, 10, 0) },
            {"TranslationProbe1/Projections/TH Scanner/ScanSource/TimberHearth", new Vector3(0, 10, 0) },
            {"TranslationProbe1/Projections/BH Scanner/ScanSource/Brittle Hollow", new Vector3(0, 10, 0) },
            {"TranslationProbe1/Projections/GD Scanner/ScanSource/Giant's Deep", new Vector3(0, 10, 0) },
            {"TranslationProbe1/Projections/DB Scanner/ScanSource/DarkBramble", new Vector3(0, 10, 0) },
            {"TranslationProbe1/Projections/TravelLine/Chime", new Vector3(0, -25, 0) },
            {"TranslationProbe1/Projections/TravelLine/Eye", new Vector3(0, 10, 0) },
            //Chime
            {"Station Redesign v2/Visual/Model/Floor/Rim", new Vector3(0, 0, -10) },
            {"Station Redesign v2/Collision/Floor/Rim", new Vector3(0, 0, -10) },
            {"Station Redesign v2/Visual/Solar Panels", new Vector3(0, 0, 10) },
            {"Station Redesign v2/Collision/Solar Panels", new Vector3(0, 0, 10) },
            {"Station Redesign v2/Orbiting Water Root", new Vector3(0, 3, 0) },
            {"Station Redesign v2/Transmitter Coin/Root/Codex Environments Projection/Scanner/Scan Source", new Vector3(0, 15, 0)},
            {"Station Redesign v2/Campfire Coin/Root/Codex Species Projection/Scanner", new Vector3(0, 5, 0)},
            {"Station Redesign v2/Other Coin/Root/Codex Galaxy Projection/ScanSource/Dot Emitter", new Vector3(0, 5, 0)},
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
                //General configuration
                AssignGhostMatterMaterial();
                FindMaterials();
                FindAudioClips();
                AssignScripts();
                AssignRotatingObjects();

                //Specific configurations
                HideFlashbackSlides();
                ReplaceSkyboxMaterial();
                IncreaseGhostMatterDamage();
                EnableEmberTreeCollision();
                
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

        void FindMaterials()
        {
            //Find materials on the asset reference prefab
            materials = new Dictionary<string, Material>();
            foreach (KeyValuePair<string, string> pair in materialsToFind)
            {
                GameObject obj = SearchUtilities.Find("MaterialReferences/" + pair.Key);
                if (obj != null)
                {
                    MeshRenderer rend = obj.GetComponent<MeshRenderer>();
                    if (rend != null)
                    {
                        Material mat = rend.material;
                        if (mat != null)
                        {
                            materials.Add(pair.Value, mat);
                            //Main.modHelper.Console.WriteLine($"FOUND MATERIAL " + pair.Value, MessageType.Success);
                        }
                        else
                            Main.modHelper.Console.WriteLine($"FAILED TO FIND MATERIAL " + pair.Value, MessageType.Error);
                    }
                    else
                        Main.modHelper.Console.WriteLine($"FAILED TO FIND RENDERER FOR MATERIAL " + pair.Value, MessageType.Error);
                }
                else
                    Main.modHelper.Console.WriteLine($"FAILED TO FIND OBJECT FOR MATERIAL " + pair.Value, MessageType.Error);
            }
        }

        void FindAudioClips()
        {
            //Find audioClips on the asset reference prefab
            audioClips = new Dictionary<string, AudioClip>();
            foreach (KeyValuePair<string, string> pair in audioClipsToFind)
            {
                GameObject obj = SearchUtilities.Find("AudioReferences/" + pair.Key);
                if (obj != null)
                {
                    AudioSource source = obj.GetComponent<AudioSource>();
                    if (source != null)
                    {
                        audioClips.Add(pair.Value, source.clip);
                    }
                    else
                        Main.modHelper.Console.WriteLine($"FAILED TO FIND AUDIO SOURCE FOR CLIP " + pair.Value, MessageType.Error);
                }
                else
                    Main.modHelper.Console.WriteLine($"FAILED TO FIND OBJECT FOR AUDIO CLIP " + pair.Value, MessageType.Error);
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
            GameObject skyboxMaterialsReference = SearchUtilities.Find("SkyboxMaterialsReference");
            if (skySphere != null && skyboxMaterialsReference != null)
            {
                MeshRenderer skyboxMaterialsReferenceRenderer = skyboxMaterialsReference.GetComponent<MeshRenderer>();
                for (int i = 0; i < skySphere.transform.childCount; i++)
                {
                    MeshRenderer renderer = skySphere.transform.GetChild(i).GetComponent<MeshRenderer>();
                    renderer.material = skyboxMaterialsReferenceRenderer.sharedMaterials[i];
                }
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND SKY SPHERE OR SKYBOX MATERIALS REFERENCE", MessageType.Error);
        }

        void IncreaseGhostMatterDamage()
        {
            //Increase the damage of ghost matter pathces to prevent the player from speeding through them
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
        #endregion

        #region Chime Configuration
        void ConfigureChime()
        {
            //Configure gameObjects in the Lingering Chime
            ParentChimeWaterToWhiteHole();
            MakeChimeSignalDetectableUnderwater();
            PutChimeClutterOnVisibleToProbeLayer();
            EnableChimeReferenceFrame();
            ConfigureProjectionPool();
        }

        void ParentChimeWaterToWhiteHole()
        {
            //Parent Chime water to white hole
            GameObject chimeWater = SearchUtilities.Find("LingeringChime_Body/Sector/Water");
            if (chimeWater != null)
            {
                GameObject chimeWhiteHoleWater = SearchUtilities.Find("Station Redesign v2/Orbiting Water Root/ChimeWhiteHoleWater");
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
                Main.modHelper.Console.WriteLine("FAILED TO FIND CHIME SIGNL", MessageType.Error);
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
                //SearchUtilities.Find("StationClutter4").layer = 22;
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
    }
}
