using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using System.Runtime.Remoting;

namespace AstralCodex
{
    class Monolith : Wire
    {
        /*Wire sunWire;
        Wire populationWire;
        Wire technologyWire;
        MeshRenderer renderer;
        GameObject monolithReveal;
        GameObject monolithEffect;

        void Start()
        {
            on = false;
            sunWire = GameObject.Find("SunWire").GetComponent<Wire>();
            populationWire = GameObject.Find("PopulationWire").GetComponent<Wire>();
            technologyWire = GameObject.Find("TechnologyWire").GetComponent<Wire>();
            monolithEffect = GameObject.Find("MonolithEffect");
            monolithEffect.AddComponent<MonolithEffect>();
            renderer = GetComponent<MeshRenderer>();

            //Disable monolith reveal
            monolithReveal = GameObject.Find("CodexReveal");
            GameObject previousMonolithReveal = null;
            while (monolithReveal != null)
            {
                monolithReveal.SetActive(false);
                previousMonolithReveal = monolithReveal;
                monolithReveal = GameObject.Find("CodexReveal");
            }
            if (previousMonolithReveal != null) monolithReveal = previousMonolithReveal;
            if (monolithReveal != null)
            {
                ShipLogFactListTriggerVolume monolithRevealTrigger = monolithReveal.GetComponent<ShipLogFactListTriggerVolume>();
                monolithRevealTrigger._player = false;
                //Main.modHelper.Console.WriteLine("FOUND MONOLITH REVEAL", MessageType.Success);
            }
        }

        void Update()
        {
            if (sunWire.on && populationWire.on && technologyWire.on)
            {
                monolithEffect.SetActive(true);
                monolithReveal.SetActive(true);
                TurnOn(renderer, null);
            }
            else
            {
                monolithEffect.SetActive(false);
                monolithReveal.SetActive(false);
                TurnOff(renderer, null);
            }
        }
        */
    }
}
