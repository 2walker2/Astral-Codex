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
        MeshRenderer timberHearthDisplayRenderer;
        GameObject reveal;
        bool shuttle = false;
        bool ship = true;

        void Start()
        {
            on = true;
            renderer = GameObject.Find("TechnologyWire").GetComponent<MeshRenderer>();
            timberHearthDisplayRenderer = GameObject.Find("SpacecraftTimberHearthDisplay").GetComponent<MeshRenderer>();
            reveal = GameObject.Find("SpacecraftCompleteReveal");
            reveal.SetActive(false);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.transform.root.CompareTag("NomaiShuttleBody")) shuttle = true;
            if (other.transform.root.CompareTag("Ship")) ship = true;
            if (on == false && (ship || shuttle))
            {
                TurnOn(renderer, reveal);
                timberHearthDisplayRenderer.material = Main.instance.materials["light"];
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.transform.root.CompareTag("NomaiShuttleBody")) shuttle = false;
            if (other.transform.root.CompareTag("Ship"))
            {
                Main.modHelper.Console.WriteLine($"SHIP LEFT");
                ship = false;
            }
            if (on == true && (!ship && !shuttle))
            {
                TurnOff(renderer, reveal);
                timberHearthDisplayRenderer.material = Main.instance.materials["black"];
            }
        }
    }
}
