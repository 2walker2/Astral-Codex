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

        public List<Transform> targets;
        public List<string> targetPaths;
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
            targets = new List<Transform>();
            foreach (string path in targetPaths)
            {
                GameObject go = SearchUtilities.Find(path);
                if (go != null)
                    targets.Add(go.transform);
                else
                    Main.modHelper.Console.WriteLine("FAILED TO FIND TRAIL TARGET " + path);
            }
            //Get material
            trailMat = GameObject.Find("StationGhostMatter/DarkMatterVolume/ObjectTrail").GetComponent<ParticleSystemRenderer>().material;
            trailMat.color = new Color(trailMat.color.r, trailMat.color.g, trailMat.color.b, 3f);
            //Initial configuration
            for (int i = 0; i < trails.Count && i < targets.Count; i++)
            {
                trails[i].gameObject.name = targets[i].name;
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
                    if (targets[i]!=null && targets[i].gameObject.activeInHierarchy)
                    {
                        trails[i].gameObject.SetActive(true);
                        //If target on QM, don't appear when moon is at 6th location
                        if (targets[i].IsChildOf(quantumMoon.transform) && quantumMoonAtmosphere.activeInHierarchy == false)
                            trails[i].gameObject.SetActive(false);
                    }
                    else
                        trails[i].gameObject.SetActive(false);

                    if (trails[i].gameObject.activeInHierarchy == true)
                    {
                        trails[i].SetPosition(0, transform.position);
                        trails[i].SetPosition(3, targets[i].position + targets[i].up * 1.5f);
                        trails[i].SetPosition(1, Vector3.Lerp(trails[i].GetPosition(0), trails[i].GetPosition(3), 0.1f));
                        trails[i].SetPosition(2, Vector3.Lerp(trails[i].GetPosition(0), trails[i].GetPosition(3), 0.89f));
                        trails[i].widthMultiplier = Mathf.Min(widthMultiplier, Vector3.Distance(trails[i].GetPosition(3), transform.position) / 50);
                    }
                }
            }
        }
    }
}
