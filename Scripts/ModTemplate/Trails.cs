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
        MeshRenderer darkBrambleCloakSphereRenderer;

        public virtual void Start()
        {
            visible = false;

            //Get QM
            quantumMoon = SearchUtilities.Find("QuantumMoon_Body");
            if (quantumMoon == null) Main.modHelper.Console.WriteLine("FAILED TO FIND QUANTUM MOON", OWML.Common.MessageType.Error);
            quantumMoonAtmosphere = SearchUtilities.Find("QuantumMoon_Body/Atmosphere_QM/AtmoSphere");
            if (quantumMoonAtmosphere == null) Main.modHelper.Console.WriteLine("FAILED TO FIND QUANTUM MOON ATMOSPHERE", OWML.Common.MessageType.Error);

            //Get Dark Bramble cloak sphere
            GameObject darkBrambleCloakSphere = SearchUtilities.Find("CloakSphere");
            if (darkBrambleCloakSphere != null)
                darkBrambleCloakSphereRenderer = darkBrambleCloakSphere.GetComponent<MeshRenderer>();
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND CLOAK SPHERE", OWML.Common.MessageType.Error);

            //Get trails
            trails = GetComponentsInChildren<LineRenderer>(true).ToList();
            if (trails.Count == 0) Main.modHelper.Console.WriteLine("NO TRAILS FOUND", OWML.Common.MessageType.Error);
            widthMultiplier = trails[0].widthMultiplier;

            //Get targets
            targets = new List<List<Transform>>();
            if (targetPaths == null) Main.modHelper.Console.WriteLine("NO TARGET PATHS", OWML.Common.MessageType.Error);
            foreach (List<string> pathList in targetPaths)
            {
                List<Transform> pathTargets = new List<Transform>();
                foreach (string path in pathList)
                {
                    GameObject go = SearchUtilities.Find(path);
                    if (go != null)
                        pathTargets.Add(go.transform);
                    else
                        Main.modHelper.Console.WriteLine("FAILED TO FIND TRAIL TARGET " + path, OWML.Common.MessageType.Error);
                }
                targets.Add(pathTargets);
            }

            //Get material
            GameObject trailMatGO = GameObject.Find("StationGhostMatterEffects");
            if (trailMatGO != null)
                trailMat = trailMatGO.GetComponent<ParticleSystemRenderer>().material;
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND TRAIL MATERIAL", OWML.Common.MessageType.Error);
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
                        if (targets[i][j] == null || !targets[i][j].gameObject.activeInHierarchy || (targets[i][j].IsChildOf(quantumMoon.transform) && quantumMoonAtmosphere.activeInHierarchy == false) || (targets[i][j].transform.root.gameObject.name.Substring(0,3) == "DB_" && darkBrambleCloakSphereRenderer.enabled == false))
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
