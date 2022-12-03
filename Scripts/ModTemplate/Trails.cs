using Harmony;
using OWML.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using NewHorizons;
using NewHorizons.Utility;

namespace AstralCodex
{
    class Trails : MonoBehaviour
    {
        public static bool visible = false;

        public List<List<Transform>> targets;
        public List<List<string>> targetPaths;
        public List<LineRenderer> trails;
        Material trailMat;
        float widthMultiplier;
        GameObject quantumMoon;
        GameObject quantumMoonAtmosphere;

        public virtual void Start()
        {
            visible = false;
            //Get QM
            quantumMoon = SearchUtilities.Find("QuantumMoon_Body");
            quantumMoonAtmosphere = quantumMoon.transform.Find("Atmosphere_QM/AtmoSphere").gameObject;
            //Get trails
            trails = GetComponentsInChildren<LineRenderer>(true).ToList();
            widthMultiplier = trails[0].widthMultiplier;
            //Get targets
            targets = new List<List<Transform>>();
            foreach (List<string> pathList in targetPaths)
            {
                List<Transform> pathTargets = new List<Transform>();
                foreach (string path in pathList)
                {
                    GameObject go = SearchUtilities.Find(path);
                    if (go != null)
                        pathTargets.Add(go.transform);
                    else
                        Main.modHelper.Console.WriteLine("FAILED TO FIND TRAIL TARGET " + path);
                }
                targets.Add(pathTargets);
            }
            //Get material
            trailMat = GameObject.Find("StationGhostMatter/DarkMatterVolume/ObjectTrail").GetComponent<ParticleSystemRenderer>().material;
            trailMat.color = new Color(trailMat.color.r, trailMat.color.g, trailMat.color.b, 3f);
            //Initial configuration
            for (int i = 0; i < trails.Count && i < targets.Count; i++)
            {
                trails[i].gameObject.name = targets[i][0].name;
                trails[i].material = trailMat;
            }
        }

        public virtual void Update()
        {
            //Ensure targets remain accurate
            if (visible == true)
            {
                for (int i = 0; i < trails.Count && i < targets.Count; i++)
                {
                    bool validTarget = false;
                    for (int j = 0; j < targets[i].Count; j++)
                    {
                        if (targets[i][j] == null || !targets[i][j].gameObject.activeInHierarchy || (targets[i][j].IsChildOf(quantumMoon.transform) && quantumMoonAtmosphere.activeInHierarchy == false))
                            continue;

                        trails[i].SetPosition(0, transform.position);
                        trails[i].SetPosition(3, targets[i][j].position + targets[i][j].up * 1.5f);
                        trails[i].SetPosition(1, Vector3.Lerp(trails[i].GetPosition(0), trails[i].GetPosition(3), 0.1f));
                        trails[i].SetPosition(2, Vector3.Lerp(trails[i].GetPosition(0), trails[i].GetPosition(3), 0.89f));
                        trails[i].widthMultiplier = Mathf.Min(widthMultiplier, Vector3.Distance(trails[i].GetPosition(3), transform.position) / 250);
                        validTarget = true;
                        break;
                    }
                    trails[i].gameObject.SetActive(validTarget);
                }
            }
        }
    }
}
