using Harmony;
using OWML.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using NewHorizons;
using NewHorizons.Utility;
using System.Collections;

namespace AstralCodex
{
    class EyeProbe : MonoBehaviour
    {
        float distance = 25;
        float lightDistance = 15;
        float lightFadeSpeed = 0.025f;
        GameObject signal;
        Transform player;
        NomaiText recorder;
        NomaiTranslator translator;
        NewHorizons.Components.Quantum.NHMultiStateQuantumObject quantumStates;
        PlayerCameraEffectController cameraEffectController;

        Dictionary<Light, float> fadeLights = new Dictionary<Light, float>();
        bool blinkCalled = false;

        void Start()
        {
            quantumStates = SearchUtilities.Find("Quantum States - codex_eye_probe").GetComponent<NewHorizons.Components.Quantum.NHMultiStateQuantumObject>();
            if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
            {
                player = SearchUtilities.Find("Player_Body").transform;
                translator = SearchUtilities.Find("Player_Body/PlayerCamera/NomaiTranslatorProp").GetComponent<NomaiTranslator>();
                recorder = SearchUtilities.Find("EyeOfTheUniverse_Body/Sector_EyeOfTheUniverse/Quantum States - codex_eye_probe/ScannerState7/Scanner Orb/Sphere/PrecursorRecorderPosition/EyeRecorderPrecursor/InteractSphere").GetComponent<NomaiText>();
                cameraEffectController = FindObjectOfType<PlayerCameraEffectController>();
                //Lights
                foreach (Light l in player.gameObject.GetComponentsInChildren<Light>())
                    fadeLights.Add(l, l.intensity);
                GameObject probe = SearchUtilities.Find("Probe_Body");
                foreach (Light l in probe.GetComponentsInChildren<Light>())
                    fadeLights.Add(l, l.intensity);
                signal = SearchUtilities.Find("EyeProbe/Signal_Translation Probe Astral");
            }
            else
            {
                //Deactivate if the player does not have the Codex
                DeactivateProbe();
                gameObject.SetActive(false);
            }
        }

        void Update()
        {
            quantumStates._isQuantum = (transform.position - player.position).magnitude < distance;
            //Disable signal once on final state
            if (quantumStates._stateIndex == quantumStates._states.Length - 1 && signal != null)
                signal.SetActive(false);
            //Lights
            if ((transform.position - player.position).magnitude < lightDistance)
            {
                foreach (KeyValuePair<Light, float> p in fadeLights)
                    p.Key.intensity = Mathf.Max(p.Key.intensity - lightFadeSpeed, 0);
            }
            else
            {
                foreach (KeyValuePair<Light, float> p in fadeLights)
                    p.Key.intensity = Mathf.Min(p.Key.intensity + lightFadeSpeed, p.Value);
            }
            //Trigger blink once recorder is read
            if (recorder._dictNomaiTextData[4].IsTranslated && !translator._isEquipped && !blinkCalled)
            {
                blinkCalled = true;
                StartCoroutine(nameof(Disappear));
            }
        }

        void DeactivateProbe()
        {
            GameObject eyeProbe = SearchUtilities.Find("EyeProbe");
            if (eyeProbe != null)
                eyeProbe.SetActive(false);
            quantumStates.gameObject.SetActive(false);
        }

        IEnumerator Disappear()
        {
            yield return new WaitForSeconds(1f);
            cameraEffectController.CloseEyes(0.25f);
            yield return new WaitForSeconds(0.25f);
            DeactivateProbe();
            cameraEffectController.OpenEyes(0.25f);
            yield return new WaitForSeconds(0.25f);
            gameObject.SetActive(false);
            yield return null;
        }
    }
}
