using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

namespace AstralCodex
{
    class SunWire : Wire
    {
        MeshRenderer cloakSphereRenderer;
        MeshRenderer sunDisplayRenderer;
        MeshRenderer renderer;
        GameObject reveal;

        void Start()
        {
            on = false;
            cloakSphereRenderer = GameObject.Find("CloakSphere").GetComponent<MeshRenderer>();
            sunDisplayRenderer = GameObject.Find("SunDisplay").GetComponent<MeshRenderer>();
            renderer = GetComponent<MeshRenderer>();
            reveal = GameObject.Find("NoSunCompleteReveal");
            Initialize(reveal);
        }

        void Update()
        {
            if (cloakSphereRenderer.enabled == true)
            {
                TurnOn(renderer, reveal);
                sunDisplayRenderer.material = Main.instance.materials["black"];
            }
            else
            {
                TurnOff(renderer, reveal);
                sunDisplayRenderer.material = Main.instance.materials["light"];
            }
        }
    }
}
