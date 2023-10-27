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
        GameObject projection; //The GameObject to enable
        Transform scroll; //The scroll that triggers the projection when picked up
        Transform parent; //The scroll's initial parent Transform
        #endregion

        #region Initialization
        void Start()
        {
            //Find scroll and parent
            scroll = SearchUtilities.Find("BrambleScroll2").transform;
            parent = scroll.parent;
            //Find projection root
            projection = SearchUtilities.Find("TranslationProbe1/Projections");
            if (projection != null)
                projection.SetActive(false);
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND BRAMBLE PROJECTION", MessageType.Error);
        }
        #endregion

        #region Update
        void Update()
        {
            //Activate projection when scroll is picked up
            if (!projection.activeInHierarchy && scroll.transform.parent != parent)
                projection.SetActive(true);
        }
        #endregion
    }
}
