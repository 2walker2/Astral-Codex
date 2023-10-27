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
    class CreditsSceneHandler : MonoBehaviour
    {
        const string SceneName = "Credits_Final";

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
            //Update end text
            if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
            {
                if (DialogueConditionManager.SharedInstance.GetConditionState("PROBE_ENTERED_EYE"))
                    GameObject.Find("14.3 Billion Years Later").GetComponent<Text>().text = "14.3 Billion Years Later\n\nThe Codec is Rediscovered";
            }
        }
        #endregion
    }
}
