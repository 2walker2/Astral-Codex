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
        #region Private Variables
        MeshRenderer cloakSphereRenderer; //The renderer on the cloaking sphere that hides the interior of Dark Bramble
        ParticleSystemRenderer partRenderer; //The renderer on the particle system attached to this object
        #endregion

        #region Initialization
        void Start()
        {
            //Align with cloak sphere
            GameObject cloakSphere = SearchUtilities.Find("CloakSphere");
            if (cloakSphere != null)
            {
                transform.parent = cloakSphere.transform;
                transform.localPosition = Vector3.zero;
                transform.localScale = Vector3.one;
                cloakSphereRenderer = cloakSphere.GetComponent<MeshRenderer>();
                cloakSphereRenderer.material = AssetHandler.materials["black"];
            }
            else
                Main.modHelper.Console.WriteLine("PARTICLES FAILED TO FIND CLOAK SPHERE");
            partRenderer = GetComponent<ParticleSystemRenderer>();
        }
        #endregion

        #region Enable/Disable Particles
        void Update()
        {
            //Match visible only when cloak sphere is visible
            partRenderer.enabled = cloakSphereRenderer.enabled;
        }
        #endregion
    }
}
