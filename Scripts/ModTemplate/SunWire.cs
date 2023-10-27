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
        #endregion

        #region Initialization
        void Start()
        {
            on = false;
            cloakSphereRenderer = GameObject.Find("CloakSphere").GetComponent<MeshRenderer>();
            sunDisplayRenderer = GameObject.Find("SunDisplay").GetComponent<MeshRenderer>();
            reveal = GameObject.Find("NoSunCompleteReveal");
            computer = SearchUtilities.Find("CodexEnvironmentsComputer").GetComponent<NomaiComputer>();
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
            }
            else
            {
                TurnOff();
                sunDisplayRenderer.material = AssetHandler.materials["light"];
            }
        }
        #endregion
    }
}
