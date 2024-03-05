using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace AstralCodex
{
    [HarmonyPatch]
    internal class Patches
    {
        //Prevent spacetime from breaking while the player has passed through the Tesseract
        /*[HarmonyPrefix]
        [HarmonyPatch(typeof(TimelineObliterationController), nameof(TimelineObliterationController.BeginTimelineObliteration))]
        public static bool TimelineObliterationController_BeginTimelineObliteration_Prefix()
        {
            if (PlayerData._currentGameSave.shipLogFactSaves.ContainsKey("codex_lingering_chime_tesseract") && PlayerData._currentGameSave.shipLogFactSaves["codex_lingering_chime_tesseract"].revealOrder > -1)
            {
                Main.modHelper.Console.WriteLine("STABILIZED SPACETIME", OWML.Common.MessageType.Success);
                TimeLoopCoreController.s_paradoxExists = false;
                return false; //Stop timeline obliteration from continuing
            }
            return true;
        }*/
    }
}
