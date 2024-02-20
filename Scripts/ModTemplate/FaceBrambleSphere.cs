using NewHorizons.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AstralCodex
{
    internal class FaceBrambleSphere : MonoBehaviour
    {
        Transform brambleSphere;

        void Start ()
        {
            brambleSphere = SearchUtilities.Find("DB_HubDimension_Body/BrambleRepelVolume/CloakSphere").transform;
        }

        void Update()
        {
           transform.LookAt(brambleSphere.position);
        }
    }
}
