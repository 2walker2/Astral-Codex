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
        public bool on = false;

        public void TurnOn(MeshRenderer renderer, GameObject reveal)
        {
            if (on == false)
            {
                on = true;
                Main.modHelper.Console.WriteLine(gameObject.name + " turned on", MessageType.Success);
                renderer.material = Main.instance.materials["green"];
                reveal.SetActive(true);
            }
        }

        public void TurnOff(MeshRenderer renderer, GameObject reveal)
        {
            if (on == true)
            {
                on = false;
                Main.modHelper.Console.WriteLine(gameObject.name + " turned off", MessageType.Success);
                renderer.material = Main.instance.materials["red"];
                reveal.SetActive(false);
            }
        }
    }
}
