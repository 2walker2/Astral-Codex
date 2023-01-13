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
        ParticleSystemRenderer partRenderer;

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
            partRenderer = GetComponent<ParticleSystemRenderer>();
        }

        void Update()
        {
            partRenderer.enabled = cloakSphereRenderer.enabled;
        }
    }
}
