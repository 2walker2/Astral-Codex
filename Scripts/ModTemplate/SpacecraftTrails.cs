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
        
        void Awake()
        {
            targetPaths = new List<string> {
                "Ship_Body",
                "Prefab_HEA_RiebeckShip",
                "Prefab_HEA_ChertShip",
                "GabbroShip_Body",
                "DarkBramble_Body",
                "Comet_Body/Prefab_NOM_Shuttle",
                "QuantumMoon_Body/Sector_QuantumMoon/QuantumShuttle/Prefab_NOM_Shuttle"
                };
        }

        public override void AdditionalTargets()
        {
            return;
        }
    }
}
