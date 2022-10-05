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
        GameObject reveal;

        void Start()
        {
            on = false;
            playerClone = GameObject.Find("TimeLoopRing_Body/Characters_TimeLoopRing").transform.GetChild(0).gameObject;
            missingPopulationDisplay = GameObject.Find("MissingPopulationDisplay").GetComponent<MeshRenderer>();
            renderer = GetComponent<MeshRenderer>();
            reveal = GameObject.Find("PopulationCompleteReveal");
            reveal.SetActive(false);
        }

        void Update()
        {
            if (playerClone.activeInHierarchy)
            {
                TurnOn(renderer, reveal);
                missingPopulationDisplay.material = Main.instance.materials["light"];
            }
            else
            {
                TurnOff(renderer, reveal);
                missingPopulationDisplay.material = Main.instance.materials["black"];
            }
        }
        
    }
}
