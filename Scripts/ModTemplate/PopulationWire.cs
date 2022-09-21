using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

namespace AstralCodex
{
    class PopulationWire : Wire
    {
        GameObject playerClone;
        MeshRenderer renderer;
        MeshRenderer missingPopulationDisplay;

        void Start()
        {
            on = false;
            playerClone = GameObject.Find("TimeLoopRing_Body/Characters_TimeLoopRing").transform.GetChild(0).gameObject;
            missingPopulationDisplay = GameObject.Find("MissingPopulationDisplay").GetComponent<MeshRenderer>();
            renderer = GetComponent<MeshRenderer>();
        }

        void Update()
        {
            if (playerClone.activeInHierarchy)
            {
                TurnOn(renderer);
                missingPopulationDisplay.material = Main.instance.materials["light"];
            }
            else
            {
                TurnOff(renderer);
                missingPopulationDisplay.material = Main.instance.materials["black"];
            }
        }
        
    }
}
