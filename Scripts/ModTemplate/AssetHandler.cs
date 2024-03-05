using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;
using UnityEngine.SceneManagement;
using System.Linq;

namespace AstralCodex
{
    //Holds assets for other scripts to access
    class AssetHandler : MonoBehaviour
    {

        #region Public Variables
        public static AssetHandler S;

        public static string assetBundlePath = "planets/assets/astral_codex";
        public static Dictionary<string, Material> materials;
        public static Dictionary<string, AudioClip> audioClips;

        public static List<Material> skyboxMaterialList;
        public static List<RenderTexture> flashbackTextureList;
        #endregion

        //Flashback settings
        int flashbackImageCount = 8;
        int[] flashbackMultiplicity = new int[] { -1, 4, 4, 4, 4, 4, 4, 25, 4 };

        #region Path Lists
        //Materials to find in the asset bundle
        Dictionary<string, string> materialsToFind = new Dictionary<string, string>()
        {
            {"Assets/Bundle/Materials/RedLight.mat", "red"},
            {"Assets/Bundle/Materials/GreenLight.mat", "green" },
            {"Assets/Bundle/Materials/Light.mat", "light" },
            {"Assets/Bundle/Materials/Black.mat", "black" },
            {"Assets/Bundle/Materials/Sprite.mat", "spritesDefault" }
        };

        //Materials to pull off objects in the base game
        Dictionary<string, string> baseGameMaterialsToFind = new Dictionary<string, string>()
        {
            {"Comet_Body/Sector_CO/Sector_CometInterior/Effects_CometInterior/Effects_GM_AuroraWisps (2)",  "ghostMatter"},
            {"TimberHearth_Body/Sector_TH/Sector_NomaiCrater/DetailPatches_NomaiCrater/NomaiCrater Foliage/Props_GhostMatter/Props_GM_Clutter", "ghostMatterCrystal" },
            {"CaveTwin_Body/Sector_CaveTwin/Sector_NorthHemisphere/Sector_NorthSurface/Sector_TimeLoopExperiment/Props_TimeLoopExperiment/Props/OtherComponentsGroup/Prefab_SandpileStatic", "sand" }
        };

        //AudioClips to find in the asset bundle
        Dictionary<string, string> audioClipsToFind = new Dictionary<string, string>()
        {
            {"Assets/Bundle/Audio/Ghost_Space.mp3", "fourDTravelMusic"},
            {"Assets/Bundle/Audio/Unveilment.mp3", "codecFinalEndTimes" }
        };

        //Skybox Materials to find in the asset bundle
        List<string> skyboxMaterialsToFind = new List<string>()
        {
            "Assets/Bundle/Materials/Skybox/SkyboxLeft.mat",
            "Assets/Bundle/Materials/Skybox/SkyboxRight.mat",
            "Assets/Bundle/Materials/Skybox/SkyboxUp.mat",
            "Assets/Bundle/Materials/Skybox/SkyboxDown.mat",
            "Assets/Bundle/Materials/Skybox/SkyboxFront.mat",
            "Assets/Bundle/Materials/Skybox/SkyboxBack.mat"
        };
        #endregion

        #region Unity Functions
        void Awake()
        {
            //Initialize singleton
            if (S == null)
                S = this;
            else
            {
                Main.modHelper.Console.WriteLine("DUPLICATE ASSET HANDLER", MessageType.Error);
                Destroy(this);
            }
        }

        void OnDestroy()
        {
            //Free up singleton
            if (S == this)
            {
                S = null;
                Main.modHelper.Console.WriteLine("ASSET HANDLER DESTROYED");
            }
        }

        #endregion

        #region Loading
        public void Load()
        {
            //Load assets
            LoadMaterials();
            LoadAudioClips();
            LoadSkyboxMaterials();
            LoadFlashbackTextures();
        }

        void LoadMaterials()
        {
            materials = new Dictionary<string, Material>();

            //Load materials from the asset bundle and store them in the material dictionary for reference
            foreach (KeyValuePair<string, string> pair in materialsToFind)
            {
                Material mat = NewHorizons.Utility.Files.AssetBundleUtilities.Load<Material>(assetBundlePath, pair.Key, Main.modBehaviour);
                if (mat != null)
                    materials.Add(pair.Value, mat);
                else
                    Main.modHelper.Console.WriteLine("FAILED TO LOAD MATERIAL " + mat.name + " FROM ASSET BUNDLE");
            }

            //Load materials from base game renderers and store them in the material dictionary for reference
            foreach (KeyValuePair<string, string> pair in baseGameMaterialsToFind)
            {
                GameObject referenceObject = SearchUtilities.Find(pair.Key);
                if (referenceObject != null)
                {
                    Renderer referenceRenderer = referenceObject.GetComponent<Renderer>();
                    if (referenceRenderer != null)
                    {
                        Material mat = referenceRenderer.material;
                        materials.Add(pair.Value, mat);
                    }
                    else
                        Main.modHelper.Console.WriteLine("FAILED TO FIND REFERENCE RENDERER FOR MATERIAL " + pair.Value);
                }
                else
                    Main.modHelper.Console.WriteLine("FAILED TO FIND REFERENCE OBJECT FOR MATERIAL " + pair.Value);
            }
        }

        void LoadAudioClips()
        {
            //Load materials from the asset bundle and store them in the material dictionary for reference
            audioClips = new Dictionary<string, AudioClip>();
            foreach (KeyValuePair<string, string> pair in audioClipsToFind)
            {
                AudioClip audio = NewHorizons.Utility.Files.AssetBundleUtilities.Load<AudioClip>(assetBundlePath, pair.Key, Main.modBehaviour);
                if (audio != null)
                    audioClips.Add(pair.Value, audio);
                else
                    Main.modHelper.Console.WriteLine("FAILED TO LOAD AUDIO CLIP " + audio.name + " FROM ASSET BUNDLE");
            }
        }

        void LoadSkyboxMaterials()
        {
            //Load materials to use for the skybox
            skyboxMaterialList = new List<Material>();
            for (int i=0; i<skyboxMaterialsToFind.Count; i++)
            {
                Material material = NewHorizons.Utility.Files.AssetBundleUtilities.Load<Material>(assetBundlePath, skyboxMaterialsToFind[i], Main.modBehaviour);
                if (material != null)
                {
                    skyboxMaterialList.Add(material);
                }
                else
                    Main.modHelper.Console.WriteLine("FAILED TO LOAD SKYBOX MATERIAL " + material.name + " FROM ASSET BUNDLE");
            }
        }

        void LoadFlashbackTextures()
        {
            //Load flashback textures
            flashbackTextureList = new List<RenderTexture>();
            for (int renderTextureIndex = flashbackImageCount; renderTextureIndex > 0; renderTextureIndex--)
            {
                Texture2D texture = Main.modHelper.Assets.GetTexture("textures/" + renderTextureIndex.ToString() + ".png");
                RenderTexture renderTexture = new RenderTexture(480, 270, 0);
                renderTexture.enableRandomWrite = true;
                RenderTexture.active = renderTexture;
                Graphics.Blit(texture, renderTexture);
                flashbackTextureList.AddRange(Enumerable.Repeat(renderTexture, flashbackMultiplicity[renderTextureIndex]));
            }
        }
        
        #endregion
    }
}
