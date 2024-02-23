using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;
using JetBrains.Annotations;

namespace AstralCodex
{
    class TechnologyWire : Wire
    {
        #region Variables
        string[] planetPaths = new string[] //Order must match order of display renderers in prefab
        {
            "CaveTwin_Body",
            "TowerTwin_Body",
            "SandFunnel_Body",
            "TimberHearth_Body",
            "BrittleHollow_Body",
            "GiantsDeep_Body",
            "DarkBramble_Body"
        };
        List<GameObject> planets;
        MeshRenderer[] planetDisplays;
        SupernovaEffectController supernovaController;
        SpacecraftDetector timberHearthSpacecraftDetector;
        SpacecraftDetector ashTwinSpacecraftDetector;
        #endregion

        #region Initialization
        void Start()
        {
            on = false;
            //reveal = GameObject.Find("SpacecraftCompleteReveal");
            computer = SearchUtilities.Find("CodexGalaxyComputer").GetComponent<NomaiComputer>();
            projection = SearchUtilities.Find("Station/Props/Projector Model Spacecraft/Codex Galaxy Projection");
            projectorRotate = SearchUtilities.Find("Station/Props/Projector Model Spacecraft/Projector_Fin/Head").GetComponent<Rotate>();

            GameObject planetDisplaysRoot = SearchUtilities.Find("Station/Spacecraft Area/SpacecraftDisplays");
            if (planetDisplaysRoot != null)
                planetDisplays = planetDisplaysRoot.GetComponentsInChildren<MeshRenderer>();
            else
                Main.modHelper.Console.WriteLine("FAILED TO FIND PLANET DISPLAYS ROOT", MessageType.Error);

            planets = new List<GameObject>();
            foreach (string planetPath in planetPaths)
            {
                planets.Add(SearchUtilities.Find(planetPath));
            }

            supernovaController = Locator.GetSunController()._supernova;

            timberHearthSpacecraftDetector = SearchUtilities.Find("TimberHearthSpacecraftDetector").GetComponent<SpacecraftDetector>();
            ashTwinSpacecraftDetector = SearchUtilities.Find("AshTwinSpacecraftDetector").GetComponent<SpacecraftDetector>();

            Initialize();
        }
        #endregion

        #region Turn On/Off
        void Update()
        {
            int numberActive = planets.Count;
            //Check spacecraft detectors
            if (ashTwinSpacecraftDetector.active)
            {
                planetDisplays[1].material = AssetHandler.materials["light"];
            }
            else
            {
                planetDisplays[1].material = AssetHandler.materials["black"];
                numberActive--;
            }

            if (timberHearthSpacecraftDetector.active)
            {
                planetDisplays[3].material = AssetHandler.materials["light"];
            }
            else
            {
                planetDisplays[3].material = AssetHandler.materials["black"];
                numberActive--;
            }

            //Check planets against supernova
            for (int i = 0; i < planets.Count; i++)
            {
                if (Vector3.Distance(supernovaController.transform.position, planets[i].transform.position) < supernovaController._currentSupernovaScale)
                {
                    planetDisplays[i].material = AssetHandler.materials["black"];
                    numberActive--;
                }
            }

            if (numberActive == planets.Count)
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
