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
        #region Protected Variables
        protected bool on = false; //Whether this wire is currently on
        protected MeshRenderer renderer; //The renderer on this wire
        protected GameObject reveal; //The GameObject containing the reveal for this wire
        protected NomaiComputer computer; //The computer containing the portion of the Codec revealed by this wire
        #endregion

        #region Initialization
        void Awake()
        {
            //Component reference
            renderer = GetComponent<MeshRenderer>();
        }

        //Called by derived wires in their Start() function
        public void Initialize()
        {
            //Set initial state
            reveal.SetActive(false);
            ShipLogFactListTriggerVolume revealTrigger = reveal.GetComponent<ShipLogFactListTriggerVolume>();
            revealTrigger._player = false;
            computer.ClearAllEntries();
        }
        #endregion

        #region Turn On/Off
        //Called by derived wires in their Update() function
        public void TurnOn()
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

        //Called by derived wires in their Update() function
        public void TurnOff()
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
        #endregion
    }
}
