using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AstralCodex
{
    class PopulationTrails : Trails
    {
        #region Target Paths
        void Awake()
        {
            //Paths to each object the trails should be pointing to
            targetPaths = new List<List<string>> {
                new List<string> {"Traveller_HEA_Player_v2" },
                new List<string> {"Villager_HEA_Slate" },
                new List<string> {"Traveller_HEA_Gabbro" },
                new List<string> {"Traveller_HEA_Chert" },
                new List<string> {"Traveller_HEA_Riebeck" },
                new List<string> {
                    "DB_PioneerDimension_Body/Sector_PioneerDimension/Interactables_PioneerDimension/Pioneer_Characters/Traveller_HEA_Feldspar",
                    "DarkBramble_Body"
                },
                new List<string> {
                    "TimberHearth_Body/Sector_TH/Sector_Village/Sector_LowerVillage/Characters_LowerVillage/Kids_PreGame/Villager_HEA_Tephra",
                    "TimberHearth_Body/Sector_TH/Sector_Village/Sector_LowerVillage/Characters_LowerVillage/Kids_Hidden/Villager_HEA_Tephra (1)",
                    "TimberHearth_Body/Sector_TH/Sector_Village/Sector_VillageCemetery/Characters_VillageCemetery/Villager_HEA_Tephra_PostObservatory"
                },
                new List<string> {
                    "TimberHearth_Body/Sector_TH/Sector_Village/Sector_LowerVillage/Characters_LowerVillage/Kids_PreGame/Villager_HEA_Galena",
                    "TimberHearth_Body/Sector_TH/Sector_Village/Sector_LowerVillage/Characters_LowerVillage/Kids_Hidden/Villager_HEA_Galena (1)"
                },
                new List<string> {"Villager_HEA_Mica" },
                new List<string> {"Villager_HEA_Gneiss" },
                new List<string> {"Villager_HEA_Spinel" },
                new List<string> {"Villager_HEA_Rutile" },
                new List<string> {"Villager_HEA_Marl" },
                new List<string> {"Villager_HEA_Porphy" },
                new List<string> {"Villager_HEA_Gossan" },
                new List<string> {"Villager_HEA_Arkose_GhostMatter" },
                new List<string> {"Villager_HEA_Moraine" },
                new List<string> {
                    "Villager_HEA_Hal_Outside",
                    "Character_HEA_Hal_Museum"
                },
                new List<string> {
                    "Villager_HEA_Tektite",
                    "Villager_HEA_Tektite_2" 
                },
                new List<string> {"Villager_HEA_Esker" },
                new List<string> {
                    "Villager_HEA_Hornfels",
                    "Villager_HEA_Hornfels (1)" 
                },
                new List<string> {"Villager_HEA_Tuff" },
                 new List<string> {
                    "QuantumMoon_Body/Sector_QuantumMoon/State_HT/Interactables_HTState/QuantumDeadNomaiSuit",
                    "QuantumMoon_Body/Sector_QuantumMoon/State_TH/Interactables_THState/QuantumDeadNomaiSuit",
                    "QuantumMoon_Body/Sector_QuantumMoon/State_BH/Interactables_BHState/QuantumDeadNomaiSuit",
                    "QuantumMoon_Body/Sector_QuantumMoon/State_GD/Interactables_GDState/QuantumDeadNomaiSuit",
                    "QuantumMoon_Body/Sector_QuantumMoon/State_DB/Interactables_DBState/QuantumDeadNomaiSuit",
                    "QuantumMoon_Body/Sector_QuantumMoon/State_EYE/Interactables_EYEState/ConversationPivot/Character_NOM_Solanum/Nomai_ANIM_SkyWatching_Idle",
                    "QuantumMoon_Body",
                    "PopulationScannerOrigin"
                },
                new List<string> {"TimeLoopRing_Body/Characters_TimeLoopRing/NPC_Player" },
                };
        }
        #endregion

        #region Initialization
        public override void Start()
        {
            base.Start();
            //Lower alpha on player trail
            Color c = trails[0].material.color;
            c.a = 0.2f;
            trails[0].material.color = c;
        }
        #endregion
    }
}
