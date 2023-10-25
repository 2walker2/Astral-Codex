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
    class EyeSceneHandler : MonoBehaviour
    {
        const string SceneName = "EyeOfTheUniverse";

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
                //Configure
                InitializeProbeParticles();
                ConfigureMuseumPlaque();
                InitializeProximityQuantumStates();
                ConfigureRecorder();
            }
        }
        #endregion

        #region Configuration
        void InitializeProbeParticles()
        {
            //Ensure probe particles don't disappear when going to the Eye
            GameObject probeParticles = SearchUtilities.Find("ProbeParticles");
            if (probeParticles != null)
            {
                probeParticles.AddComponent<ProbeParticles>();
                probeParticles.transform.GetChild(0).GetChild(0).localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        }

        void ConfigureMuseumPlaque()
        {
            //Configure museum plaque
            GameObject plaque = SearchUtilities.Find("ProbePlaque");
            GameObject plaqueDialogue = SearchUtilities.Find("PlaqueDialogue");
            if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
            {
                //The player has the codex ship log entry
                //Initialize dialogue
                if (plaqueDialogue != null)
                {
                    CharacterDialogueTree plaqueDialogueTree = plaqueDialogue.GetComponent<CharacterDialogueTree>();
                    Transform probeAttention = SearchUtilities.Find("EyeOfTheUniverse_Body/Sector_EyeOfTheUniverse/Sector_Observatory/Interactables_Observatory/AttentionPoint_WarpCore").transform;
                    plaqueDialogueTree._attentionPoint = probeAttention;
                    plaqueDialogueTree._turnOffFlashlight = false;
                    plaqueDialogueTree._turnOnFlashlight = false;
                }
                //Configure light
                GameObject plaqueLightGO = SearchUtilities.Find("ProbePlaque/PointLight_HEA_MuseumPlaque");
                if (plaqueLightGO != null)
                {
                    Light plaqueLight = plaqueLightGO.GetComponent<Light>();
                    plaqueLight.intensity = 1.5f;
                    plaqueLight.color = Color.cyan;
                }
                //Configure light model
                GameObject plaqueLightModel = SearchUtilities.Find("ProbePlaque/Props_HEA_MuseumPlaque_Geo/lantern_lamp");
                if (plaqueLightModel != null)
                    plaqueLightModel.GetComponent<MeshRenderer>().material.color = Color.cyan;
            }
            else
            {
                //The player doesn't have the codex ship log entry
                if (plaque != null)
                    plaque.SetActive(false);
                if (plaqueDialogue != null)
                    plaqueDialogue.SetActive(false);
            }
        }
        
        void InitializeProximityQuantumStates()
        {
            //Make the translation probe's quantum states turn quantum on proximity
            GameObject quantumProximityController = SearchUtilities.Find("QuantumProximityController");
            if (quantumProximityController != null)
                quantumProximityController.AddComponent<EyeProbe>();
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND QUANTUM PROXIMITY CONTROLLER", MessageType.Error);
        }

        void ConfigureRecorder()
        {
            //Reparent final recorder
            GameObject precursorRecorder = SearchUtilities.Find("EyeRecorderPrecursor");
            GameObject precursorRecorderLocation = SearchUtilities.Find("PrecursorRecorderPosition");
            if (precursorRecorder != null && precursorRecorderLocation != null)
            {
                precursorRecorder.transform.parent = precursorRecorderLocation.transform;
                precursorRecorder.transform.localPosition = Vector3.zero;
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND PRECURSOR RECORDER OR ITS ANCHOR", MessageType.Error);
        }
        #endregion
    }
}
