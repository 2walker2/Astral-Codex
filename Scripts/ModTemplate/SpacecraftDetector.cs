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
        public static int numberActive = 0;
        public static int numberPresent = 0;

        static Dictionary<string, string> planetIcons = new Dictionary<string, string>
        {
            {"TimberHearthSpacecraftDetector", "SpacecraftDisplays/TimberHearth" },
            {"AshTwinSpacecraftDetector", "SpacecraftDisplays/HourglassTwins/AshTwin" }
        };

        bool ship = false;
        bool shuttle = false;
        bool modelShip = false;
        bool active = false;
        MeshRenderer planetIcon;

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
            coll.enabled = false;
            coll.enabled = true;
            if (gameObject.name == "InterloperSpacecraftDetector" || gameObject.name == "QuantumMoonSpacecraftDetector") shuttle = true;
            if (gameObject.name == "TimberHearthSpacecraftDetector") modelShip = true;
            if (shuttle || ship || modelShip)
            {
                active = true;
                numberActive++;
                planetIcon.material = Main.instance.materials["light"];
            }
            else
                planetIcon.material = Main.instance.materials["black"];
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.transform.root.CompareTag("NomaiShuttleBody")) shuttle = true;
            if (other.transform.root.CompareTag("Ship")) ship = true;
            if (other.transform.root.CompareTag("ModelRocketShipBody")) modelShip = true;
            if (ship || shuttle || modelShip)
            {
                if (planetIcon != null)
                    planetIcon.material = Main.instance.materials["light"];
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
                    planetIcon.material = Main.instance.materials["black"];
                if (active == true)
                    numberActive--;
                active = false;
            }
        }
    }
}
