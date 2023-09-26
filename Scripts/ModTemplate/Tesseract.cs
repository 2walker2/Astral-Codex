using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons;
using NewHorizons.Utility;
using UnityEngine.PostProcessing;

namespace AstralCodex
{
    class Tesseract : MonoBehaviour
    {
        List<Transform> points;
        List<LineRenderer> lineRenderers;
        float time;
        List<Vector3> trackPoints;
        List<int> timeOffsets;
        GameObject fourDParticles;
        GameObject fourDParticles2;
        int fourDLayer = 0;
        float timeStayed = 0;
        float secondLayerDelay = 10f;
        GameObject trailsReveal;
        GameObject skySphere;
        int skySphereDisabled = 0;

        void Awake()
        {
            //Constants
            trackPoints = new List<Vector3>() { new Vector3(-1, 1, 1), new Vector3(1, 1, 1), new Vector3(2, 2, 2), new Vector3(-2, 2, 2) };
            timeOffsets = new List<int>() { 0, 1, 1, 0, 0, 1, 1, 0, 3, 2, 2, 3, 3, 2, 2, 3 };
        }

        void Start()
        {
            points = new List<Transform>(transform.Find("Points").GetComponentsInChildren<Transform>());
            points.RemoveAt(0);
            lineRenderers = new List<LineRenderer>(GetComponentsInChildren<LineRenderer>());
            time = 0;
            fourDParticles = transform.Find("4DParticles").gameObject;
            fourDParticles2 = transform.Find("4DParticles2").gameObject;
            trailsReveal = SearchUtilities.Find("TrailsReveal");
            if (trailsReveal != null)
                trailsReveal.SetActive(false);
            skySphere = SearchUtilities.Find("Skybox/Sky Sphere");

            //Save tesseract state from previous loops
            if (PlayerData.GetPersistentCondition("CODEX_ENTERED_TESSERACT"))
                EnteredTesseract(true);
        }

        void LateUpdate()
        {
            //Initially disable skySphere
            if (fourDLayer == 0 && skySphereDisabled == 5)
            {
                if (skySphere != null)
                    skySphere.SetActive(false);
            }
            skySphereDisabled++;

            //Ensure correct layers remain visible
            if (Camera.main != null && fourDLayer != 0)
            {
                // Visible to Probe visible unless on layer 0
                if ((Camera.main.cullingMask & (1 << 22)) == 0)
                    Camera.main.cullingMask += (1 << 22);
            }

            //Animate tesseract
            time += Time.deltaTime;
            for (int i = 0; i < points.Count; ++i)
            {
                //Loop variables
                LineRenderer lr = lineRenderers[i];
                Transform p = points[i];
                Vector3[] positions = new Vector3[3];

                //Move points
                float t = (time + timeOffsets[i]) % 4;
                float tt = t % 1;
                int track = Mathf.FloorToInt(t);
                Vector3 trackStart = trackPoints[track];
                Vector3 trackEnd;
                if (track >= trackPoints.Count - 1) trackEnd = trackPoints[0];
                else trackEnd = trackPoints[track + 1];
                Vector3 newPosition = new Vector3(Mathf.Lerp(trackStart.x, trackEnd.x, tt), Mathf.Lerp(trackStart.y, trackEnd.y, tt), Mathf.Lerp(trackStart.z, trackEnd.z, tt));
                newPosition.y *= Mathf.Sign(p.transform.localPosition.y);
                newPosition.z *= Mathf.Sign(p.transform.localPosition.z);
                p.transform.localPosition = newPosition;

                //Render lines
                //Own position
                positions[1] = p.position;
                //Next position
                if ((i + 1) % 4 == 0) positions[0] = points[i - 3].position;
                else positions[0] = points[i + 1].position;
                //Connecting positions
                int connectingIndex = i + 4;
                if (connectingIndex >= points.Count) connectingIndex -= points.Count;
                positions[2] = points[connectingIndex].position;
                //Apply positions
                lr.SetPositions(positions);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            //Move into 4D
            if (other.gameObject.CompareTag("Player"))
            {
                //Main.modHelper.Console.WriteLine($"ENTERED TESSERACT", MessageType.Success);
                if (fourDLayer == 0)
                    EnteredTesseract(true);
                else
                    EnteredTesseract(false);
            }
        }

        private void EnteredTesseract(bool value)
        {
            //Disable probe launcher overlay
            int cameraLayer = 28;
            if (!value)
                cameraLayer = 12;
            Transform[] probeLauncherRenderers = GameObject.Find("Props_HEA_ProbeLauncher_ProbeCamera").GetComponentsInChildren<Transform>();
            foreach (Transform r in probeLauncherRenderers) r.gameObject.layer = cameraLayer;

            //Instantiate effect
            fourDParticles.SetActive(false);
            fourDParticles.SetActive(true);

            //Enable skybox
            if (skySphere != null)
                skySphere.SetActive(value);

            //Adjust post processing
            PostProcessingGameplaySettings postProcessingSettings = Locator.GetPlayerCamera().postProcessingSettings;
            if (value)
            {
                postProcessingSettings.colorGrading.temperature = -25;
                postProcessingSettings.colorGrading.tint = -50;
            }
            else
            {
                postProcessingSettings.colorGrading.temperature = 0;
                postProcessingSettings.colorGrading.tint = 0;
            }
            

            //Set persistent condition
            PlayerData.SetPersistentCondition("CODEX_ENTERED_TESSERACT", value);

            if (value)
                fourDLayer = 1;
            else
            {
                fourDLayer = 0;
                if ((Camera.main.cullingMask & (1 << 22)) != 0)
                    Camera.main.cullingMask -= (1 << 22);
            }
                
        }

        void OnTriggerStay(Collider other)
        {
            if (fourDLayer != 2)
            {
                timeStayed += Time.deltaTime;
                //Second 4D layer
                if (timeStayed > secondLayerDelay)
                {
                    EnteredTesseract(true);
                    fourDLayer = 2;
                    fourDParticles2.SetActive(true);
                    Trails.visible = true;
                    if (trailsReveal != null)
                        trailsReveal.SetActive(true);
                }
            }
        }

        void OnTriggerExit(Collider other)
        {
            timeStayed = 0;
        }
    }
}
