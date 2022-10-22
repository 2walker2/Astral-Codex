using Harmony;
using OWML.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AstralCodex
{
    class Trails : MonoBehaviour
    {
        public List<Transform> targets;
        public List<string> targetPaths;
        List<LineRenderer> trails;
        Material trailMat;
        float widthMultiplier;
        GameObject quantumMoon;
        GameObject sixthLocation;

        public virtual void Start()
        {
            //Get QM
            quantumMoon = GameObject.Find("QuantumMoon_Body");
            sixthLocation = quantumMoon.transform.Find("Sector_QuantumMoon/State_EYE").gameObject;
            //Get trails
            trails = GetComponentsInChildren<LineRenderer>().ToList();
            widthMultiplier = trails[0].widthMultiplier;
            //Get targets
            targets = new List<Transform>();
            foreach (string path in targetPaths)
            {
                GameObject go = GameObject.Find(path);
                if (go != null)
                    targets.Add(go.transform);
                else
                    Main.modHelper.Console.WriteLine("FAILED TO FIND TRAIL TARGET " + path);
            }
            AdditionalTargets();
            //Get material
            //trailMat = GameObject.Find("StationGhostMatter/DarkMatterVolume/ObjectTrail").GetComponent<ParticleSystemRenderer>().material;
            //trailMat.color = new Color(trailMat.color.r, trailMat.color.g, trailMat.color.b, 3f);
            //Initial configuration
            for (int i = 0; i < trails.Count && i < targets.Count; i++)
            {
                trails[i].gameObject.name = targets[i].name;
                trails[i].material = trailMat;
                if (targets[i].gameObject.activeInHierarchy)
                    trails[i].enabled = true;
                else
                    trails[i].enabled = false;
            }
            //Lower alpha on player and ship trails
            Color c = trails[0].material.color;
            c.a = 1f;
            trails[0].material.color = c;
        }

        public virtual void AdditionalTargets()
        {
            return;
        }

        public virtual void Update()
        {
            //Ensure targets remain accurate
            for (int i=0; i<trails.Count && i<targets.Count; i++)
            {
                if (targets[i].gameObject.activeInHierarchy)
                {
                    trails[i].enabled = true;
                    //If target on QM, don't appear when target is at 6th location
                    if (targets[i].IsChildOf(quantumMoon.transform) && sixthLocation.activeInHierarchy == true)
                        trails[i].enabled = false;
                }
                else
                    trails[i].enabled = false;

                if (trails[i].enabled == true)
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
