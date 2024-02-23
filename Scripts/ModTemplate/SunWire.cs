using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;

namespace AstralCodex
{
    class SunWire : Wire
    {
        #region Private Variables
        MeshRenderer cloakSphereRenderer; //The renderer on the cloaking sphere around the interior of Dark Bramble
        MeshRenderer sunDisplayRenderer; //The renderer on the display for the sun in the Chime
        GameObject chimeLensLight; //The gameObject of the light representing refracted light from the Sun
        #endregion

        #region Initialization
        void Start()
        {
            on = false;
            
            //Component references
            cloakSphereRenderer = GameObject.Find("CloakSphere").GetComponent<MeshRenderer>();
            sunDisplayRenderer = GameObject.Find("SunDisplay").GetComponent<MeshRenderer>();
            //reveal = GameObject.Find("NoSunCompleteReveal");
            computer = SearchUtilities.Find("CodexEnvironmentsComputer").GetComponent<NomaiComputer>();
            projection = SearchUtilities.Find("Station/Props/Projector Model Sun/Codex Environments Projection");
            chimeLensLight = SearchUtilities.Find("Station/Lighting/Top Light");
            projectorRotate = SearchUtilities.Find("Station/Props/Projector Model Sun/Projector_Fin/Head").GetComponent<Rotate>();
            
            Initialize();
        }
        #endregion

        #region Turn On/Off
        void Update()
        {
            //If the cloak sphere's renderer is active, something is in Dark Bramble
            if (cloakSphereRenderer.enabled == true)
            {
                TurnOn();
                sunDisplayRenderer.material = AssetHandler.materials["black"];
                chimeLensLight.SetActive(false);
            }
            else
            {
                TurnOff();
                sunDisplayRenderer.material = AssetHandler.materials["light"];
                chimeLensLight.SetActive(true);
            }
        }
        #endregion
    }
}
