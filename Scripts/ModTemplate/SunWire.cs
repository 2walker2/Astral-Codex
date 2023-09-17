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
        MeshRenderer cloakSphereRenderer;
        MeshRenderer sunDisplayRenderer;
        MeshRenderer renderer;
        GameObject reveal;
        NomaiComputer computer;

        void Start()
        {
            on = false;
            cloakSphereRenderer = GameObject.Find("CloakSphere").GetComponent<MeshRenderer>();
            sunDisplayRenderer = GameObject.Find("SunDisplay").GetComponent<MeshRenderer>();
            renderer = GetComponent<MeshRenderer>();
            reveal = GameObject.Find("NoSunCompleteReveal");
            computer = SearchUtilities.Find("CodexEnvironmentsComputer").GetComponent<NomaiComputer>();
            Initialize(reveal, computer);
        }

        void Update()
        {
            if (cloakSphereRenderer.enabled == true)
            {
                TurnOn(renderer, reveal, computer);
                sunDisplayRenderer.material = Main.instance.materials["black"];
            }
            else
            {
                TurnOff(renderer, reveal, computer);
                sunDisplayRenderer.material = Main.instance.materials["light"];
            }
        }
    }
}
