using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;
using UnityEngine.SceneManagement;
using System.Linq;
using Harmony;
using Newtonsoft.Json.Linq;

namespace AstralCodex
{
    internal class TrailActivation : Wire
    {
        const string TrailsActivatedCondition = "CODEX_TRAILS_ACTIVATED";
        bool triggered = false;
        float activationDelay = 5f;
        float timeStayed = 0f;
        bool trailsActivated = false;
        GameObject trailsReveal;
        Rotate populationOrbRotator;
        Rotate spacecraftOrbRotator;
        PopulationTrails populationTrails;
        SpacecraftTrails spacecraftTrails;

        void Start()
        {
            on = false;
            Initialize();

            trailsReveal = SearchUtilities.Find("TrailsReveal");
            populationOrbRotator = SearchUtilities.Find("Station/Spacecraft Area/Scanner/Orb").GetComponent<Rotate>();
            spacecraftOrbRotator = SearchUtilities.Find("Station/Population Area/Scanner/Orb").GetComponent<Rotate>();
            populationTrails = FindObjectOfType<PopulationTrails>();
            spacecraftTrails = FindObjectOfType<SpacecraftTrails>();

            //Restore state from last loop
            if (PlayerData.GetPersistentCondition(TrailsActivatedCondition))
                trailsActivated = true;
            ActivateTrails(trailsActivated);

        }

        void OnTriggerStay(Collider other)
        {
            if (triggered || other.gameObject != Locator.GetPlayerBody().gameObject)
                return;

            timeStayed += Time.deltaTime;
            if (timeStayed > activationDelay)
            {
                trailsActivated = !trailsActivated;
                triggered = true;
                ActivateTrails(trailsActivated);
            }
        }

        void ActivateTrails(bool value)
        {
            if (value)
                TurnOn();
            else
                TurnOff();

            populationTrails.root.SetActive(value);
            spacecraftTrails.root.SetActive(value);

            trailsReveal.SetActive(value);
            populationOrbRotator.enabled = value;
            spacecraftOrbRotator.enabled = value;

            PlayerData.SetPersistentCondition(TrailsActivatedCondition, value);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject != Locator.GetPlayerBody().gameObject)
                return;
            
            timeStayed = 0f;
        }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject != Locator.GetPlayerBody().gameObject)
                return;

            triggered = false;
        }
    }
}
