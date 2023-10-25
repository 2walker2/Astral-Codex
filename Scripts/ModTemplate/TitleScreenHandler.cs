using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;
using UnityEngine.SceneManagement;

namespace AstralCodex
{
    //Configures the title screen
    class TitleScreenHandler : MonoBehaviour
    {
        void Awake()
        {
            //Initialize the scene loaded callback
            SceneManager.sceneLoaded += OnSceneLoaded;

            //The title screen is already loaded when this script is created, so initialize it immediately
            InitializeScene();
        }

        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            InitializeScene();
        }

        void InitializeScene()
        {
            //Add the tesseract to the title screen
            string pathInBundle = "Assets/Bundle/Tesseract.prefab";
            GameObject titleTesseract = (GameObject)Instantiate(NewHorizons.Utility.Files.AssetBundleUtilities.Load<GameObject>(Main.assetBundlePath, pathInBundle, Main.modBehaviour), new Vector3(-35, 100, -20), Quaternion.identity);
            titleTesseract.AddComponent<Tesseract>();
        }
    }
}
