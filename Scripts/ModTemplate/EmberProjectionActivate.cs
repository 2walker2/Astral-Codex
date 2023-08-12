using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;

namespace AstralCodex
{
    class EmberProjectionActivate : MonoBehaviour
    {
        NomaiTextLine line;
        GameObject projection;

        void Start()
        {
            //Find activation text arc
            GameObject arc = SearchUtilities.Find("TranslationCairn5/Props_TH_ClutterSmall/Arc_Short/Arc");
            if (arc != null)
                line = arc.GetComponent<NomaiTextLine>();
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND EMBER PROJECTION ACTIVATION ARC", MessageType.Error);
            //Find projection root
            projection = SearchUtilities.Find("TranslationProbe2/Projections");
            if (projection != null)
                projection.SetActive(false);
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND EMBER PROJECTION", MessageType.Error);
        }

        void Update()
        {
            //Activate projection when text is read
            if (!projection.activeInHierarchy && line._state == NomaiTextLine.VisualState.TRANSLATED)
                projection.SetActive(true);
        }
    }
}
