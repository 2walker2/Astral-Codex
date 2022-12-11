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
        Transform player;
        Dictionary<Light, float> fadeLights = new Dictionary<Light, float>();

        void Start()
        {
            player = SearchUtilities.Find("Player_Body").transform;
            //Lights
            foreach (Light l in player.gameObject.GetComponentsInChildren<Light>())
                fadeLights.Add(l, l.intensity);
            GameObject probe = SearchUtilities.Find("Probe_Body");
            foreach (Light l in probe.GetComponentsInChildren<Light>())
                fadeLights.Add(l, l.intensity);
        }

        void Update()
        {
            quantumStates._isQuantum = (transform.position - player.position).magnitude < distance;
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
