using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons;
using NewHorizons.Utility;

namespace AstralCodex
{
    class ProbeParticles: MonoBehaviour
    {
        #region Variables
        bool suppressed = false;
        ParticleSystem particleSystem; //The particle system on this object
        #endregion

        #region Initialization
        void Start()
        {
            //Attach particles to probe
            GameObject probeBody = SearchUtilities.Find("Probe_Body");
            if (probeBody != null)
            {
                transform.parent = probeBody.transform;
                transform.localPosition = new Vector3(0,0,-0.25f);
                transform.localRotation = Quaternion.identity;
            }
            particleSystem = GetComponentInChildren<ParticleSystem>();
        }
        #endregion

        #region Play Particles
        void Update()
        {
            if (!suppressed && !particleSystem.isPlaying && PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
                particleSystem.Play();
        }

        public void Suppress(bool value)
        {
            suppressed = value;
            particleSystem.gameObject.SetActive(!suppressed);
        }
        #endregion
    }
}
