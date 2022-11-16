using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

namespace AstralCodex
{
    class TechnologyWire : Wire
    {
        MeshRenderer renderer;
        GameObject reveal;

        void Start()
        {
            on = false;
            renderer = GetComponent<MeshRenderer>();
            reveal = GameObject.Find("SpacecraftCompleteReveal");
            reveal.SetActive(false);
        }

        void Update()
        {
            if (SpacecraftDetector.numberActive == SpacecraftDetector.numberPresent)
            {
                TurnOn(renderer, reveal);
            }
            else
            {
                TurnOff(renderer, reveal);
            }
        }
    }
}
