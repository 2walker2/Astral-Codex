using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AstralCodex
{
    class PopulationTrails : MonoBehaviour
    {
        List<Transform> targets;
        List<LineRenderer> trails;

        void Start()
        {
            //Get trails
            trails = GetComponentsInChildren<LineRenderer>().ToList();
            //Get targets
            targets = new List<Transform>();
            targets.Add(GameObject.Find("Villager_HEA_Slate").transform); //Slate
        }

        void Update()
        {
            //Ensure targets remain accurate
            for (int i=0; i<trails.Count; i++)
            {
                trails[i].SetPosition(0, transform.position);
                trails[i].SetPosition(1, targets[i].position);
            }
        }
    }
}
