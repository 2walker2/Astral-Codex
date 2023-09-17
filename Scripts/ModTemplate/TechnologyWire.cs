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
        MeshRenderer renderer;
        GameObject reveal;
        NomaiComputer computer;

        void Start()
        {
            on = false;
            renderer = GetComponent<MeshRenderer>();
            reveal = GameObject.Find("SpacecraftCompleteReveal");
            computer = SearchUtilities.Find("CodexGalaxyComputer").GetComponent<NomaiComputer>();
            Initialize(reveal, computer);
        }

        void Update()
        {
            if (SpacecraftDetector.numberActive == SpacecraftDetector.numberPresent)
            {
                TurnOn(renderer, reveal, computer);
            }
            else
            {
                TurnOff(renderer, reveal, computer);
            }
        }
    }
}
