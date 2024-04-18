using OWML.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using NewHorizons;
using NewHorizons.Utility;
using System.Collections;

namespace AstralCodex
{
    class EyeProbe : MonoBehaviour
    {
        #region Private Variables
        float distance = 25; //The distance the player must be within for quantum states to update
        float lightDistance = 15; //The distance at which lights are deactivated
        float lightFadeSpeed = 0.025f; //The speed at which lights fade
        GameObject signal; //The GameObject holding the signal
        Transform player; //The player's transform
        NomaiText recorder; //The recorder GameObject spawned by the final quantum state
        GameObject recorderGO; //The parent GameObject of the recorder
        NomaiTranslator translator; //The player's translator tool
        NewHorizons.Components.Quantum.NHMultiStateQuantumObject quantumStates; //The QuantumStates component
        PlayerCameraEffectController cameraEffectController; //The effect controller on the main camera
        OWAudioSource musicSource; //The audio source for the precursor Campfire Song
        OWAudioSource musicFinaleSource; //The audio source for the finale of the precursor Campfire Song
        QuantumCampsiteController campsiteController; //The campsite controller in the Ancient Glade
        CosmicInflationController cosmicInflationController; //The cosmic inflation controller in the Ancient Glade

        Dictionary<Light, float> fadeLights = new Dictionary<Light, float>(); //The lights that should be deactivated when the player approaches the probe
        bool blinkCalled = false; //Whether the player's camera has been told to blink
        bool finaleStarted = false; //Whether the finale of the precursor Campfire Song has started
        #endregion

        #region Initialization
        void Start()
        {
            quantumStates = SearchUtilities.Find("Quantum States - codex_eye_probe").GetComponent<NewHorizons.Components.Quantum.NHMultiStateQuantumObject>();
            if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_astral_codex_fact") && PlayerData._currentGameSave.shipLogFactSaves["codex_astral_codex_fact"].revealOrder > -1)
            {
                //Component references
                player = Locator.GetPlayerTransform();
                translator = SearchUtilities.Find("Player_Body/PlayerCamera/NomaiTranslatorProp").GetComponent<NomaiTranslator>();
                recorder = SearchUtilities.Find("EyeOfTheUniverse_Body/Sector_EyeOfTheUniverse/Quantum States - codex_eye_probe/ScannerState7/Scanner Orb/Sphere/PrecursorRecorderPosition/EyeRecorderPrecursor/InteractSphere").GetComponent<NomaiText>();
                recorderGO = recorder.transform.parent.gameObject;
                cameraEffectController = FindObjectOfType<PlayerCameraEffectController>();
                musicSource = SearchUtilities.Find("EyeOfTheUniverse_Body/Sector_EyeOfTheUniverse/Sector_Campfire/InstrumentZones/EyeProbe/MusicSource").GetComponent<OWAudioSource>();
                musicFinaleSource = SearchUtilities.Find("EyeOfTheUniverse_Body/Sector_EyeOfTheUniverse/Sector_Campfire/InstrumentZones/EyeProbe/MusicFinaleSource").GetComponent<OWAudioSource>();
                campsiteController = SearchUtilities.Find("Sector_Campfire").GetComponent<QuantumCampsiteController>();
                cosmicInflationController = SearchUtilities.Find("EyeOfTheUniverse_Body/Sector_EyeOfTheUniverse/Sector_Campfire/InflationController").GetComponent<CosmicInflationController>();
                //Lights
                foreach (Light l in player.gameObject.GetComponentsInChildren<Light>())
                    fadeLights.Add(l, l.intensity);
                GameObject probe = SearchUtilities.Find("Probe_Body");
                foreach (Light l in probe.GetComponentsInChildren<Light>())
                    fadeLights.Add(l, l.intensity);
                signal = SearchUtilities.Find("EyeOfTheUniverse_Body/Sector_EyeOfTheUniverse/Sector_Campfire/InstrumentZones/EyeProbe/AudioSource");
            }
            else
            {
                //Deactivate if the player does not have the Codex
                DeactivateProbe();
                gameObject.SetActive(false);
            }
        }
        #endregion

        #region Update
        void Update()
        {
            //Enable/disable ability to change quantum state based on distance
            quantumStates._isQuantum = (transform.position - player.position).magnitude < distance;

            //Lights
            /*if ((transform.position - player.position).magnitude < lightDistance)
            {
                foreach (KeyValuePair<Light, float> p in fadeLights)
                {
                    if (p.Key != null)
                        p.Key.intensity = Mathf.Max(p.Key.intensity - lightFadeSpeed, 0);
                }
            }
            else
            {
                foreach (KeyValuePair<Light, float> p in fadeLights)
                {
                    if (p.Key != null)
                        p.Key.intensity = Mathf.Min(p.Key.intensity + lightFadeSpeed, p.Value);
                }
            }*/

            //Trigger blink once recorder is read
            if (recorder._dictNomaiTextData[10].IsTranslated && !translator._isEquipped && !blinkCalled)
            {
                blinkCalled = true;
                StartCoroutine(nameof(Disappear));
            }
        }
        #endregion

        #region Music
        void LateUpdate()
        {
            //Finale starts when CosmicInflationController starts waiting for crossfade to the finale to start
            if (cosmicInflationController._waitForCrossfade && !musicFinaleSource.isPlaying)
            {
                musicSource.FadeOut(5);
                musicFinaleSource.FadeIn(5, true);
                finaleStarted = true;
            }
            //Audio joins in once any of the travelers are playing
            else if (!finaleStarted)
            {
                if (campsiteController._hasJamSessionStarted && !musicSource.isPlaying)
                    musicSource.FadeIn(5, true);
            }
        }
        #endregion

        #region Remove Probe
        void DeactivateProbe()
        {
            GameObject eyeProbe = SearchUtilities.Find("EyeProbe");
            if (eyeProbe != null)
                eyeProbe.SetActive(false);
            quantumStates.gameObject.SetActive(false);
        }

        IEnumerator Disappear()
        {
            yield return new WaitForSeconds(1f);
            cameraEffectController.CloseEyes(0.25f);
            yield return new WaitForSeconds(0.25f);
            
            recorderGO.SetActive(false);
            signal.SetActive(false);

            cameraEffectController.OpenEyes(0.25f);
        }
        #endregion
    }
}
