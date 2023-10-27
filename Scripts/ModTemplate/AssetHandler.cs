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
        public static string assetBundlePath = "planets/assets/astral_codex";
        public static Dictionary<string, Material> materials;
        public static Dictionary<string, AudioClip> audioClips;

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

        //AudioClips to find in the asset bundle
        Dictionary<string, string> audioClipsToFind = new Dictionary<string, string>()
        {
            {"Assets/Bundle/Audio/Ghost_Space.mp3", "fourDTravelMusic"}
        };
        #endregion

        #region Loading
        void Awake()
        {
            //Load assets
            LoadMaterials();
            LoadAudioClips();
        }

        void LoadMaterials()
        {
            //Load materials from the asset bundle and store them in the material dictionary for reference
            materials = new Dictionary<string, Material>();
            foreach (KeyValuePair<string, string> pair in materialsToFind)
            {
                Material mat = NewHorizons.Utility.Files.AssetBundleUtilities.Load<Material>(assetBundlePath, pair.Key, Main.modBehaviour);
                if (mat != null)
                    materials.Add(pair.Value, mat);
                else
                    Main.modHelper.Console.WriteLine("FAILED TO LOAD MATERIAL " + mat.name + " FROM ASSET BUNDLE");
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
