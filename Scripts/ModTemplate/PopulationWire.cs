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
        GameObject playerClone;
        MeshRenderer renderer;
        MeshRenderer missingPopulationDisplay;
        GameObject reveal;
        NomaiComputer computer;

        void Start()
        {
            on = false;
            playerClone = GameObject.Find("TimeLoopRing_Body/Characters_TimeLoopRing").transform.GetChild(0).gameObject;
            missingPopulationDisplay = GameObject.Find("MissingPopulationDisplay").GetComponent<MeshRenderer>();
            renderer = GetComponent<MeshRenderer>();
            reveal = GameObject.Find("PopulationCompleteReveal");
            computer = SearchUtilities.Find("CodexSpeciesComputer").GetComponent<NomaiComputer>();
            Initialize(reveal, computer);
        }

        void Update()
        {
            if (playerClone.activeInHierarchy)
            {
                TurnOn(renderer, reveal, computer);
                missingPopulationDisplay.material = AssetHandler.materials["light"];
            }
            else
            {
                TurnOff(renderer, reveal, computer);
                missingPopulationDisplay.material = AssetHandler.materials["black"];
            }
        }
        
    }
}
