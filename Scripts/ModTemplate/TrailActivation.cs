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
        bool playerInTrigger = false;
        float activationDelay = 5f;
        float timeStayed = 0f;
        bool trailsActivated = false;
        GameObject trailsReveal;
        Rotate populationOrbRotator;
        Rotate spacecraftOrbRotator;
        PopulationTrails populationTrails;
        SpacecraftTrails spacecraftTrails;
        AudioSource audioSource;
        OWTriggerVolume triggerVolume;

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
            triggerVolume = GetComponent<OWTriggerVolume>();

            //Restore state from last loop
            if (PlayerData.GetPersistentCondition(TrailsActivatedCondition))
                trailsActivated = true;
            ActivateTrails(trailsActivated, false);

            //Register trigger volume callbacks
            triggerVolume.OnEntry += OnEntry;
            triggerVolume.OnExit += OnExit;
        }

        private void OnEntry(GameObject hitObj)
        {
            if (hitObj.CompareTag("PlayerDetector"))
            {
                timeStayed = 0f;
                playerInTrigger = true;
            }
        }

        private void OnExit(GameObject hitObj)
        {
            if (hitObj.CompareTag("PlayerDetector"))
            {
                playerInTrigger = false;
                triggered = false;
            }
        }

        void Update()
        {
            if (playerInTrigger && !triggered)
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
            
        }

        void OnTriggerExit(Collider other)
        {
            
        }
    }
}
