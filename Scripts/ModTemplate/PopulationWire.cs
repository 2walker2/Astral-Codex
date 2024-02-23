using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;

namespace AstralCodex
{
    class PopulationWire : Wire
    {
        #region Private Variables
        MeshRenderer[] populationSegments;
        PopulationTrails trails;
        #endregion

        #region Initialization
        void Start()
        {
            on = false;

            //Component references
            //playerClone = GameObject.Find("TimeLoopRing_Body/Characters_TimeLoopRing").transform.GetChild(0).gameObject;
            //missingPopulationDisplay = GameObject.Find("MissingPopulationDisplay").GetComponent<MeshRenderer>();

            GameObject populationSegmentsRoot = SearchUtilities.Find("Station/Population Area/PopulationDisplays");
            if (populationSegmentsRoot != null)
            {
                populationSegments = populationSegmentsRoot.GetComponentsInChildren<MeshRenderer>();
            }
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND POPULATION DISPLAY ROOT", MessageType.Error);
            trails = FindObjectOfType<PopulationTrails>();

            //reveal = GameObject.Find("PopulationCompleteReveal");
            computer = SearchUtilities.Find("CodexSpeciesComputer").GetComponent<NomaiComputer>();
            projection = SearchUtilities.Find("Station/Props/Projector Model Population/Codex Species Projection");
            projectorRotate = SearchUtilities.Find("Station/Props/Projector Model Population/Projector_Fin/Head").GetComponent<Rotate>();

            Initialize();
        }
        #endregion

        #region Turn On/Off
        void Update()
        {
            //Reflect the trail status on the displays
            int trailsActive = 0;
            for (int i=0; i<populationSegments.Length; i++)
            {
                if (trails.trails[i].gameObject.activeSelf)
                {
                    populationSegments[i].material = AssetHandler.materials["light"];
                    trailsActive++;
                }
                else
                {
                    populationSegments[i].material = AssetHandler.materials["black"];
                }
            }

            //Turn on if every trail is on
            if (trailsActive == populationSegments.Length)
            {
                TurnOn();
            }
            else
            {
                TurnOff();
            }
        }
        #endregion
    }
}
