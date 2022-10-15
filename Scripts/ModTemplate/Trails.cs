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

        void Start()
        {
            //Get trails
            trails = GetComponentsInChildren<LineRenderer>().ToList();
            trails[0].widthMultiplier = 0.1f;
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
            //Get material
            trailMat = GameObject.Find("StationGhostMatter/DarkMatterVolume/ObjectTrail").GetComponent<ParticleSystemRenderer>().material;
            trailMat.color = new Color(trailMat.color.r, trailMat.color.g, trailMat.color.b, 3f);
            //Initial configuration
            for (int i = 0; i < trails.Count && i < targets.Count; i++)
            {
                if (targets[i].gameObject.activeInHierarchy)
                {
                    trails[i].enabled = true;
                    trails[i].gameObject.name = targets[i].name;
                    trails[i].material = trailMat;
                }
                else
                    trails[i].enabled = false;
            }
        }

        public virtual void AdditionalTargets()
        {
            return;
        }

        void Update()
        {
            //Ensure targets remain accurate
            for (int i=0; i<trails.Count && i<targets.Count; i++)
            {
                if (trails[i].enabled == true)
                {
                    if (targets[i].gameObject.activeInHierarchy)
                    {
                        trails[i].enabled = true;
                        trails[i].SetPosition(0, transform.position);
                        trails[i].SetPosition(3, targets[i].position + targets[i].up);
                        trails[i].SetPosition(1, Vector3.Lerp(trails[i].GetPosition(0), trails[i].GetPosition(3), 0.1f));
                        trails[i].SetPosition(2, Vector3.Lerp(trails[i].GetPosition(0), trails[i].GetPosition(3), 0.89f));
                    }
                    else
                        trails[i].enabled = false;
                }
            }
        }
    }
}
