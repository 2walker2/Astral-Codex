using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;

namespace AstralCodex
{
    class PopulationWire : Wire
    {
        #region Private Variables
        GameObject playerClone; //The player's clone in the ATP
        MeshRenderer missingPopulationDisplay; //The renderer of the missing segment in the population display
        #endregion

        #region Initialization
        void Start()
        {
            on = false;

            //Component references
            playerClone = GameObject.Find("TimeLoopRing_Body/Characters_TimeLoopRing").transform.GetChild(0).gameObject;
            missingPopulationDisplay = GameObject.Find("MissingPopulationDisplay").GetComponent<MeshRenderer>();
            reveal = GameObject.Find("PopulationCompleteReveal");
            computer = SearchUtilities.Find("CodexSpeciesComputer").GetComponent<NomaiComputer>();
        }
        #endregion

        #region Turn On/Off
        void Update()
        {
            if (playerClone.activeInHierarchy)
            {
                TurnOn();
                missingPopulationDisplay.material = AssetHandler.materials["light"];
            }
            else
            {
                missingPopulationDisplay.material = AssetHandler.materials["black"];
            }
        }
        #endregion
    }
}
