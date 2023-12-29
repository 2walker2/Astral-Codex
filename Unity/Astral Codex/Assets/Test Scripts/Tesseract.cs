using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

class Tesseract : MonoBehaviour
{
    List<Transform> points;
    List<LineRenderer> lineRenderers;
    List<LineRenderer> waveRenderers;
    float waveHeight = 10;
    float waveScale = 10;
    float waveWidth = 10;
    float waveSpeed = 1;
    float time;
    List<Vector3> trackPoints;
    List<int> timeOffsets;
    GameObject fourDParticles;
    GameObject fourDParticles2;
    int fourDLayer = 0;
    float timeStayed = 0;
    float secondLayerDelay = 7f;
    Camera mapCamera;

    void Awake()
    {
        //Constants
        trackPoints = new List<Vector3>() { new Vector3(-1, 1, 1), new Vector3(1, 1, 1), new Vector3(2, 2, 2), new Vector3(-2, 2, 2) };
        timeOffsets = new List<int>() { 0, 1, 1, 0, 0, 1, 1, 0, 3, 2, 2, 3, 3, 2, 2, 3 };
    }

    void Start()
    {
        //Get points
        Transform pointsAnchor = transform.Find("Points");
        points = new List<Transform>(pointsAnchor.GetComponentsInChildren<Transform>());
        points.RemoveAt(0);
        lineRenderers = new List<LineRenderer>(pointsAnchor.GetComponentsInChildren<LineRenderer>());
        //Get waves
        waveRenderers = new List<LineRenderer>(transform.Find("Waves").GetComponentsInChildren<LineRenderer>());
        //Initialize
        time = 0;
        fourDParticles = transform.Find("4DParticles").gameObject;
        fourDParticles2 = transform.Find("4DParticles2").gameObject;
    }

    void Update()
    {
        //Ensure correct layers remain visible
        if (Camera.main != null)
        {
            if (fourDLayer != 0)
            {
                // Visible to Probe visible unless on layer 0
                if ((Camera.main.cullingMask & (1 << 22)) == 0)
                    Camera.main.cullingMask += (1 << 22);
                if (mapCamera!=null && (mapCamera.cullingMask & (1 << 22)) == 0)
                    mapCamera.cullingMask += (1 << 22);
            }
            if (fourDLayer == 2)
            {
                // Unused visible on layer 2
                if ((Camera.main.cullingMask & (1 << 12)) == 0)
                    Camera.main.cullingMask += (1 << 12);
                if (mapCamera != null && (mapCamera.cullingMask & (1 << 12)) == 0)
                    mapCamera.cullingMask += (1 << 12);
            }
            else
            {
                // Unused invisible unless on layer 2
                if ((Camera.main.cullingMask & (1 << 12)) != 0)
                    Camera.main.cullingMask -= (1 << 12);
                if (mapCamera != null && (mapCamera.cullingMask & (1 << 12)) != 0)
                    mapCamera.cullingMask -= (1 << 12);
            }
        }

        //Animate tesseract
        time += Time.deltaTime;
        //Tesseract
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
        //Waves
        for (int i=0; i<waveRenderers.Count; i++)
        {
            LineRenderer rend = waveRenderers[i];
            int tMultiplier = i * 2 - 1;
            for (int j=0; j < waveRenderers[i].positionCount; j++)
            {
                float z = (float)j / waveRenderers[i].positionCount * waveScale;
                float r = Mathf.Sin(z / waveScale * Mathf.PI) * waveHeight;
                float t = time * tMultiplier;
                rend.SetPosition(j, new Vector3(rend.gameObject.transform.position.x + Mathf.Sin(t) * r, rend.gameObject.transform.position.y + Mathf.Cos(t) * r, rend.gameObject.transform.position.z + z));
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Move into 4D
        if (other.gameObject.CompareTag("Player"))
        {
            if (fourDLayer == 0)
            {   
                //Disable probe launcher overlay
                Transform[] probeLauncherRenderers = GameObject.Find("Props_HEA_ProbeLauncher_ProbeCamera").GetComponentsInChildren<Transform>();
                foreach (Transform r in probeLauncherRenderers) r.gameObject.layer = 28;

                //Instantiate effect
                fourDParticles.SetActive(true);

                fourDLayer = 1;
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (fourDLayer == 1)
        {
            timeStayed += Time.deltaTime;
            //Second 4D layer
            if (timeStayed > secondLayerDelay)
            {
                fourDLayer = 2;
                fourDParticles2.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        timeStayed = 0;
    }
}
