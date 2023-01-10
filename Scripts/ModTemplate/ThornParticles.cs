using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons;
using NewHorizons.Utility;

namespace AstralCodex
{
    class ThornParticles: MonoBehaviour
    {
        MeshRenderer cloakSphereRenderer;
        ParticleSystem part;

        void Start()
        {
            GameObject cloakSphere = SearchUtilities.Find("CloakSphere");
            if (cloakSphere != null)
            {
                transform.parent = cloakSphere.transform;
                transform.localPosition = Vector3.zero;
                transform.localScale = Vector3.one;
                cloakSphereRenderer = cloakSphere.GetComponent<MeshRenderer>();
            }
            else
                Main.modHelper.Console.WriteLine("PARTICLES FAILED TO FIND CLOAK SPHERE");
            part = GetComponent<ParticleSystem>();
        }

        void Update()
        {
            /*if (part.isPlaying && cloakSphereRenderer.enabled == false)
                part.Stop(false, ParticleSystemStopBehavior.StopEmittingAndClear);
            else if (!part.isPlaying && cloakSphereRenderer.enabled == true)
                part.Play();*/
        }
    }
}
