using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;

namespace AstralCodex
{
    class BrambleProjectionActivate : MonoBehaviour
    {
        #region Private Variables
        //The paths to the projection objects to activate
        string[] projectionPaths = {
            "TranslationProbe1/ScaleRoot/Model/HT Projector Ring/HT Scanner",
            "TranslationProbe1/ScaleRoot/Model/TH Projector Ring/TH Scanner",
            "TranslationProbe1/ScaleRoot/Model/BH Projector Ring/BH Scanner",
            "TranslationProbe1/ScaleRoot/Model/GD Projector Ring/GD Scanner",
            "TranslationProbe1/ScaleRoot/Model/DB Projector Ring/DB Scanner",
            "TranslationProbe1/ScaleRoot/Model/Sun Projector/Sun Scanner",
            "TranslationProbe1/Projections"
        };

        bool active = false; //Whether the projection is currently active
        GameObject[] projectionGOs; //The GameObjects to enable
        Transform scroll; //The scroll that triggers the projection when picked up
        Transform parent; //The scroll's initial parent Transform
        #endregion

        #region Initialization
        void Start()
        {
            //Find scroll and parent
            scroll = SearchUtilities.Find("BrambleScroll2").transform;
            parent = scroll.parent;

            //Find projection GameObjects and disable them initially
            projectionGOs = new GameObject[projectionPaths.Length];
            for (int i = 0; i < projectionPaths.Length; i++)
            {
                GameObject projectionGO = SearchUtilities.Find(projectionPaths[i]);
                if (projectionGO != null)
                {
                    projectionGO.SetActive(false);
                    projectionGOs[i] = projectionGO;
                }
                else
                {
                    Main.modHelper.Console.WriteLine("FAILED TO FIND BRAMBLE PROJECTION " + projectionPaths[i], MessageType.Error);
                }
            }
        }
        #endregion

        #region Update
        void Update()
        {
            //Activate projection when scroll is picked up
            if (!active && scroll.transform.parent != parent)
            {
                foreach (GameObject p in projectionGOs)
                {
                    p.SetActive(true);
                }
            }
        }
        #endregion
    }
}
