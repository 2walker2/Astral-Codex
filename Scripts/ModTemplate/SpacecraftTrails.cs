using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AstralCodex
{
    class SpacecraftTrails : Trails
    {
        #region Target Paths
        void Awake()
        {
            //The objects to point trails at
            targetPaths = new List<List<string>> {
                new List<string> {"Ship_Body" },
                new List<string> {"Prefab_HEA_RiebeckShip" },
                new List<string> {"Prefab_HEA_ChertShip" },
                new List<string> {"GabbroShip_Body" },
                new List<string> {
                    "FeldsparShip_Body",
                    "DarkBramble_Body"
                },
                new List<string> {"Comet_Body/Prefab_NOM_Shuttle" },
                new List<string> {"QuantumMoon_Body/Sector_QuantumMoon/QuantumShuttle/Prefab_NOM_Shuttle" },
                new List<string> {"ModelRocket_Body" },
                new List<string> {
                    "DB_VesselDimension_Body/Sector_VesselDimension/Sector_VesselBridge/Interactibles_VesselBridge/WarpController/WarpCoreSocket",
                    "DarkBramble_Body"
                },
                new List<string> { "AlphaShipMarker" }
            };
        }
        #endregion
    }
}
