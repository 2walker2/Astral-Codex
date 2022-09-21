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

        void Start()
        {
            on = false;
            cloakSphereRenderer = GameObject.Find("CloakSphere").GetComponent<MeshRenderer>();
            sunDisplayRenderer = GameObject.Find("SunDisplay").GetComponent<MeshRenderer>();
            renderer = GetComponent<MeshRenderer>();
        }

        void Update()
        {
            if (cloakSphereRenderer.enabled == true)
            {
                TurnOn(renderer);
                sunDisplayRenderer.material = Main.instance.materials["black"];
            }
            else
            {
                TurnOff(renderer);
                sunDisplayRenderer.material = Main.instance.materials["light"];
            }
        }
    }
}
