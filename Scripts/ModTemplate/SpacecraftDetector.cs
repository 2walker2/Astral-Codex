using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using NewHorizons.Utility;
using System;
using Harmony;
using System.Collections;

namespace AstralCodex
{
    class SpacecraftDetector : MonoBehaviour
    {
        //Known bug: Probably breaks if multiple Nomai shuttles enter the same SpacecraftDetector and then one leaves

        #region Static Variables
        public static int numberActive = 0; //The number of SpacecraftDetectors with a ship in them in the scene
        public static int numberPresent = 0; //The number of SpacecraftDetectors in the scene

        //The icons associated with each SpacecraftDetector
        static Dictionary<string, string> planetIcons = new Dictionary<string, string>
        {
            {"TimberHearthSpacecraftDetector", "SpacecraftDisplays/TimberHearth" },
            {"AshTwinSpacecraftDetector", "SpacecraftDisplays/HourglassTwins/AshTwin" }
        };
        #endregion

        #region Private Variables
        bool ship = false; //Whether the player's ship is inside this SpacecraftDetector
        bool shuttle = false; //Whether a Nomai shuttle is inside this SpacecraftDetector
        bool modelShip = false; //Whether the model ship is inside this SpacecraftDetector
        bool active = false; //Whether this SpacecraftDetector has a spacecraft inside it
        MeshRenderer planetIcon; //The planet icon associated with this SpacecraftDetector
        #endregion

        #region Enable/Disable Handling
        void OnEnable()
        {
            numberPresent++;
            if (active == true)
                numberPresent++;
        }

        void OnDisable()
        {
            numberPresent--;
            if (active == true)
                numberActive--;
        }
        #endregion

        #region Initialization
        void Awake()
        {
            //Find planet icon
            if (!planetIcons.ContainsKey(gameObject.name))
            {
                Main.modHelper.Console.WriteLine("Failed to find planet icon dictionary entry for " + gameObject.name, MessageType.Error);
                return;
            }
            GameObject iconObject = SearchUtilities.Find(planetIcons[gameObject.name]);
            if (iconObject == null)
            {
                Main.modHelper.Console.WriteLine("Failed to find planet icon object for " + gameObject.name, MessageType.Error);
                return;
            }
            planetIcon = iconObject.GetComponent<MeshRenderer>();
        }
        
        void Start()
        {
            Collider coll = GetComponent<Collider>();

            //Toggle collider to detect objects that start inside it
            coll.enabled = false;
            coll.enabled = true;

            //Initial state
            if (gameObject.name == "InterloperSpacecraftDetector" || gameObject.name == "QuantumMoonSpacecraftDetector") shuttle = true;
            if (gameObject.name == "TimberHearthSpacecraftDetector") modelShip = true;
            if (shuttle || ship || modelShip)
            {
                active = true;
                numberActive++;
                planetIcon.material = AssetHandler.materials["light"];
            }
            else
                planetIcon.material = AssetHandler.materials["black"];
        }
        #endregion

        #region Detect Spacecraft
        void OnTriggerEnter(Collider other)
        {
            if (other.transform.root.CompareTag("NomaiShuttleBody")) shuttle = true;
            if (other.transform.root.CompareTag("Ship")) ship = true;
            if (other.transform.root.CompareTag("ModelRocketShipBody")) modelShip = true;
            if (ship || shuttle || modelShip)
            {
                if (planetIcon != null)
                    planetIcon.material = AssetHandler.materials["light"];
                if (active == false)
                    numberActive++;
                active = true;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.transform.root.CompareTag("NomaiShuttleBody")) shuttle = false;
            if (other.transform.root.CompareTag("Ship")) ship = false;
            if (other.transform.root.CompareTag("ModelRocketShipBody")) modelShip = false;
            if (!ship && !shuttle && !modelShip)
            {
                if (planetIcon != null)
                    planetIcon.material = AssetHandler.materials["black"];
                if (active == true)
                    numberActive--;
                active = false;
            }
        }
        #endregion
    }
}
