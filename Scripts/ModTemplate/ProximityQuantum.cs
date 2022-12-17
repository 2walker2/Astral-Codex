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

namespace AstralCodex
{
    class ProximityQuantum : MonoBehaviour
    {
        public NewHorizons.Components.Quantum.NHMultiStateQuantumObject quantumStates;

        float distance = 25;
        float lightDistance = 15;
        float lightFadeSpeed = 0.025f;
        GameObject signal;
        Transform player;
        Dictionary<Light, float> fadeLights = new Dictionary<Light, float>();

        void Start()
        {
            if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
            {
                player = SearchUtilities.Find("Player_Body").transform;
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
                GameObject eyeProbe = SearchUtilities.Find("EyeProbe");
                if (eyeProbe != null)
                    eyeProbe.SetActive(false);
                quantumStates.gameObject.SetActive(false);
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
        }
    }
}
