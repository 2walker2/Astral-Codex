using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;
using UnityEngine.SceneManagement;
using System.Linq;

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
        AudioSource audioSource;

        void Start()
        {
            on = false;
            Initialize();

            trailsReveal = SearchUtilities.Find("TrailsReveal");
            populationOrbRotator = SearchUtilities.Find("Station/Spacecraft Area/Scanner/Orb").GetComponent<Rotate>();
            spacecraftOrbRotator = SearchUtilities.Find("Station/Population Area/Scanner/Orb").GetComponent<Rotate>();
            populationTrails = FindObjectOfType<PopulationTrails>();
            spacecraftTrails = FindObjectOfType<SpacecraftTrails>();
            audioSource = GetComponent<AudioSource>();

            //Restore state from last loop
            if (PlayerData.GetPersistentCondition(TrailsActivatedCondition))
                trailsActivated = true;
            ActivateTrails(trailsActivated, false);

        }

        void OnTriggerStay(Collider other)
        {
            if (triggered)
                return;

            if (other.gameObject.GetAttachedOWRigidbody().CompareTag("Player"))
            {
                timeStayed += Time.deltaTime;
                if (timeStayed > activationDelay)
                {
                    trailsActivated = !trailsActivated;
                    triggered = true;
                    ActivateTrails(trailsActivated);
                }
            }
        }

        void ActivateTrails(bool value, bool playSound = true)
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

            if (playSound)
                audioSource.Play();

            PlayerData.SetPersistentCondition(TrailsActivatedCondition, value);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetAttachedOWRigidbody().CompareTag("Player"))
                timeStayed = 0f;
        }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject.GetAttachedOWRigidbody().CompareTag("Player"))
                triggered = false;
        }
    }
}
