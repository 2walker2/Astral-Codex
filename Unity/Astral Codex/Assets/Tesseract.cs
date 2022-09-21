using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesseract : MonoBehaviour
{
    public List<Vector3> trackPoints;
    public float time;
    public List<int> timeOffsets;

    List<Transform> points;
    List<LineRenderer> lineRenderers;

    // Start is called before the first frame update
    void Start()
    {
        points = new List<Transform>(GetComponentsInChildren<Transform>());
        points.RemoveAt(0);
        lineRenderers = new List<LineRenderer>(GetComponentsInChildren<LineRenderer>());
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        for (int i=0; i<points.Count; ++i)
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
            if ((i + 1) % 4 == 0) positions[0] = points[i-3].position;
            else positions[0] = points[i + 1].position;
            //Connecting positions
            int connectingIndex = i + 4;
            if (connectingIndex >= points.Count) connectingIndex -= points.Count;
            positions[2] = points[connectingIndex].position;
            //Apply positions
            lr.SetPositions(positions);
        }
    }
}
