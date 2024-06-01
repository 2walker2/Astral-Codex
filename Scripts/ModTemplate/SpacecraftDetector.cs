using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using NewHorizons.Utility;
using System;

using System.Collections;

namespace AstralCodex
{
    class SpacecraftDetector : MonoBehaviour
    {
        //Known bug: Probably breaks if multiple Nomai shuttles enter the same SpacecraftDetector and then one leaves

        #region Variables
        public bool active = false; //Whether this SpacecraftDetector has a spacecraft inside it

        bool ship = false; //Whether the player's ship is inside this SpacecraftDetector
        bool shuttle = false; //Whether a Nomai shuttle is inside this SpacecraftDetector
        bool modelShip = false; //Whether the model ship is inside this SpacecraftDetector

        Rigidbody shuttleBody = null; //The rigidbody of the shuttle (if any) inside this detector
        float shuttleForce = 100f; //The force to apply to a shuttle within this detector to avoid it bouncing off the planet
        #endregion

        #region Initialization
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
                active = true;
        }
        #endregion

        #region Pull Shuttle In
        void Update()
        {
            if (shuttle && shuttleBody != null)
            {
                Main.modHelper.Console.WriteLine("Applying shuttle force", MessageType.Success);
                Vector3 forceDirection = (transform.position - shuttleBody.transform.position).normalized;
                shuttleBody.AddForce(forceDirection * shuttleForce);
            }
        }
        #endregion

        #region Detect Spacecraft
        void OnTriggerEnter(Collider other)
        {
            if (other.transform.root.CompareTag("NomaiShuttleBody"))
            {
                Main.modHelper.Console.WriteLine("Shuttle entered detector", MessageType.Success);
                shuttle = true;
                shuttleBody = other.GetComponentInParent<Rigidbody>();
            }
            if (other.transform.root.CompareTag("Ship")) ship = true;
            if (other.transform.root.CompareTag("ModelRocketShipBody")) modelShip = true;
            if (ship || shuttle || modelShip)
            {
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
                active = false;
            }
        }
        #endregion
    }
}
