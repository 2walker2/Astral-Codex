
using OWML.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using NewHorizons;
using NewHorizons.Utility;
using System.ComponentModel.Design.Serialization;

namespace AstralCodex
{
    class Trails : MonoBehaviour
    {
        #region Public Variables
        public List<List<Transform>> targets; //These trails' target Transforms
        public List<List<string>> targetPaths; //The paths to these trails' target Transforms
        public List<LineRenderer> trails; //The trail LineRenderers controlled by this script
        public GameObject root; //The root gameObject of all the trails
        #endregion

        #region Private Variables
        Material trailMat; //The material to apply to the trails
        float widthMultiplier; //The mutliplier to apply to each trail's width
        GameObject quantumMoon; //The Quantum Moon's body's GameObject
        GameObject quantumMoonAtmosphere; //The Quantum Moon's atmosphere's GameObject
        GameObject quantumMoonEyeState; //The root GameObject of the EOTU state of the Quantum Moon
        MeshRenderer darkBrambleCloakSphereRenderer; //The renderer attached to the cloaking sphere that hides the interior of Dark Bramble
        SupernovaEffectController supernovaController; //The sun's supernova controller
        #endregion

        #region Initialization
        public virtual void Start()
        {
            //Get root
            root = transform.GetChild(0).gameObject;
            root.SetActive(false);

            //Get QM
            quantumMoon = SearchUtilities.Find("QuantumMoon_Body");
            if (quantumMoon == null) Main.modHelper.Console.WriteLine("FAILED TO FIND QUANTUM MOON", OWML.Common.MessageType.Error);
            quantumMoonAtmosphere = SearchUtilities.Find("QuantumMoon_Body/Atmosphere_QM/AtmoSphere");
            if (quantumMoonAtmosphere == null) Main.modHelper.Console.WriteLine("FAILED TO FIND QUANTUM MOON ATMOSPHERE", OWML.Common.MessageType.Error);
            quantumMoonEyeState = SearchUtilities.Find("QuantumMoon_Body/Sector_QuantumMoon/State_EYE");
            if (quantumMoonEyeState == null) Main.modHelper.Console.WriteLine("FAILED TO FIND QUANTUM MOON EYE STATE", OWML.Common.MessageType.Error);
            supernovaController = Locator.GetSunController()._supernova;

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
            trailMat = AssetHandler.materials["ghostMatter"];
            trailMat.color = new Color(trailMat.color.r, trailMat.color.g, trailMat.color.b, 3f); //Make material brighter
            
            //Initial configuration
            for (int i = 0; i < trails.Count && i < targets.Count; i++)
            {
                trails[i].gameObject.name = targets[i][0].name;
                trails[i].material = trailMat;
            }
        }
        #endregion

        #region Update Trail Positions
        public virtual void Update()
        {
            for (int i = 0; i < trails.Count && i < targets.Count; i++)
            {
                bool validTarget = false;
                //Iterate over each possible target for this trail until one is valid
                for (int j = 0; j < targets[i].Count; j++)
                {
                    //Skip if any of the following are true:
                    //1. The target doesn't exist
                    //2. The target is disabled
                    //3. The target is on the Quantum Moon and the QM is at the 6th location
                    //4. The target is inside Dark Bramble and the interior is not manifested
                    //5. The target is within the supernova
                    if (targets[i][j] == null ||
                        !targets[i][j].gameObject.activeInHierarchy ||
                        (targets[i][j].IsChildOf(quantumMoon.transform) && quantumMoonAtmosphere.activeInHierarchy == false && quantumMoonEyeState.activeInHierarchy == false) ||
                        (targets[i][j].transform.root.gameObject.name.Substring(0,3) == "DB_" && darkBrambleCloakSphereRenderer.enabled == false) ||
                        (Vector3.Distance(targets[i][j].position, supernovaController.transform.position) < supernovaController._currentSupernovaScale && targets[i][j].root.gameObject.name != "TimeLoopRing_Body"))
                    {
                        continue;
                    }

                    trails[i].SetPosition(0, transform.position); //The start of the trail
                    trails[i].SetPosition(3, targets[i][j].position + targets[i][j].up * 1.5f); //The trail's target (offset to approximate pointing at NPCs' heads)
                    //Intermediate points for smoother width interpolation
                    trails[i].SetPosition(1, Vector3.Lerp(trails[i].GetPosition(0), trails[i].GetPosition(3), 0.1f));
                    trails[i].SetPosition(2, Vector3.Lerp(trails[i].GetPosition(0), trails[i].GetPosition(3), 0.89f));
                        
                    trails[i].widthMultiplier = Mathf.Min(widthMultiplier, Vector3.Distance(trails[i].GetPosition(3), transform.position) / 250);
                    validTarget = true;
                    break;
                }
                trails[i].gameObject.SetActive(validTarget);
            }
        }
        #endregion
    }
}
