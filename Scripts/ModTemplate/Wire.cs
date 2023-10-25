using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace AstralCodex
{
    class Wire : MonoBehaviour
    {
        protected bool on = false;

        public void Initialize(GameObject reveal, NomaiComputer computer)
        {
            reveal.SetActive(false);
            ShipLogFactListTriggerVolume revealTrigger = reveal.GetComponent<ShipLogFactListTriggerVolume>();
            revealTrigger._player = false;
            computer.ClearAllEntries();
        }

        public void TurnOn(MeshRenderer renderer, GameObject reveal, NomaiComputer computer)
        {
            if (on == false)
            {
                on = true;
                //Main.modHelper.Console.WriteLine(gameObject.name + " turned on", MessageType.Success);
                renderer.material = AssetHandler.materials["green"];
                reveal.SetActive(true);
                computer.DisplayAllEntries();
            }
        }

        public void TurnOff(MeshRenderer renderer, GameObject reveal, NomaiComputer computer)
        {
            if (on == true)
            {
                on = false;
                //Main.modHelper.Console.WriteLine(gameObject.name + " turned off", MessageType.Success);
                renderer.material = AssetHandler.materials["red"];
                reveal.SetActive(false);
                computer.ClearAllEntries();
            }
        }
    }
}
