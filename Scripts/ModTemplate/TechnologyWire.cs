using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;

namespace AstralCodex
{
    class TechnologyWire : Wire
    {
        #region Initialization
        void Start()
        {
            on = false;
            //reveal = GameObject.Find("SpacecraftCompleteReveal");
            computer = SearchUtilities.Find("CodexGalaxyComputer").GetComponent<NomaiComputer>();
            projection = SearchUtilities.Find("Station/Props/Projector Model (2)/Codex Galaxy Projection");
            Initialize();
        }
        #endregion

        #region Turn On/Off
        void Update()
        {
            if (SpacecraftDetector.numberActive == SpacecraftDetector.numberPresent)
            {
                TurnOn();
                //The display is handled by the SpacecraftDetectors
            }
            else
            {
                TurnOff();
                //The display is handled by the SpacecraftDetectors
            }
        }
        #endregion
    }
}
