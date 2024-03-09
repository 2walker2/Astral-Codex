/**
 * Custom scripts for Astral Codex
 * Author: Walker
 * 
 * Note: This code was developed with goal of implementing basic functionality as quickly and simply as possible
 * in order to control development time on a large-scale design-focused project.
 * It often does not represent the best way to do things.
 */

using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using NewHorizons.Utility;
using HarmonyLib;
using System.Reflection;

namespace AstralCodex
{
    public class Main : ModBehaviour
    {
        //DEBUG
        public static bool debugMode = false; //CHANGE ON RELEASE

        //Constant values
        public static string assetBundlePath = "planets/assets/astral_codex";

        //Constant references
        public static IModHelper modHelper;
        public static IModBehaviour modBehaviour;
        public static INewHorizons newHorizons;
        public static Main S;

        void Awake()
        {
            //Initialize instance
            if (S == null) S = this;

            //Apply Harmony patches
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }

        private void Start()
        {
            //Get the mod helper (accessible starting here)
            modHelper = ModHelper;
            ModHelper.Console.WriteLine($"ASTRAL CODEC mod loaded", MessageType.Success);

            //Get the mod behaviour
            modBehaviour = this;

            //Initialize New Horizons configs
            newHorizons = ModHelper.Interaction.TryGetModApi<INewHorizons>("xen.NewHorizons");
            newHorizons.LoadConfigs(this);

            //Locate the GameObject that holds this script
            GameObject modBehaviourGO = SearchUtilities.Find(ModHelper.Manifest.UniqueName);
            if (modBehaviourGO != null)
            {
                //Add asset handler component
                modBehaviourGO.AddComponent<AssetHandler>();

                //Add scene handler components
                modBehaviourGO.AddComponent<TitleScreenHandler>();
                modBehaviourGO.AddComponent<SolarSystemSceneHandler>();
                modBehaviourGO.AddComponent<EyeSceneHandler>();
                modBehaviourGO.AddComponent<CreditsSceneHandler>();
                modBehaviourGO.AddComponent<PostCreditsSceneHandler>();
            }
            else
                ModHelper.Console.WriteLine("FAILED TO FIND MOD BEHAVIOUR GAMEOBJECT", MessageType.Error);
        }
    }
}
