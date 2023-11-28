using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Utility;

namespace AstralCodex
{
    class GhostMatterMaterial : MonoBehaviour
    {
        //The path to the gameObject used as the source of the material
        const string materialSourcePath = "TimberHearth_Body/Sector_TH/Sector_NomaiCrater/DetailPatches_NomaiCrater/NomaiCrater Foliage/Props_GhostMatter/Props_GM_Clutter";

        #region Variables
        //Renderers to not apply the material to
        static List<string> renderersToExclude = new List<string>()
        {
            "ring_text_glow",
            "Arc",
            "ShellLaticeFilled",
            "ShellLatice",
            "Ring1", "Ring2", "Ring3", "Ring4", "Ring5", "Ring6", "Ring7"
        };
        static Material material; //The ghost matter material crystal to apply
        
        List<MeshRenderer> renderers; //The mesh renderers on this object and its children
        float delay = 0.5f; //The time to wait before applying the material to ensure everything is fully loaded
        #endregion

        #region Apply Material
        void Start()
        {
            renderers = new List<MeshRenderer>(GetComponentsInChildren<MeshRenderer>());
            NewHorizons.Utility.OWML.Delay.FireOnNextUpdate(ApplyMaterial);
            //Invoke(nameof(ApplyMaterial), delay);
        }

        void ApplyMaterial()
        {
            //Find the material if it hasn't been found yet
            if (material == null)
            {
                GameObject ghostMatterClutter = SearchUtilities.Find(materialSourcePath);
                if (ghostMatterClutter != null)
                    material = ghostMatterClutter.GetComponent<MeshRenderer>().material;
            }

            //Apply the material to this object
            if (material != null)
            {
                if (renderers != null && renderers.Count > 0)
                {
                    foreach (MeshRenderer r in renderers)
                    {
                        if (r.material != material)
                        {
                            if (!renderersToExclude.Contains(r.gameObject.name))
                            {
                                r.material = material;
                            }
                            r.gameObject.layer = NewHorizons.Utility.OuterWilds.Layer.VisibleToProbe; ;
                        }
                    }
                }
            }
            else
                Main.modHelper.Console.WriteLine("ATTEMPTED TO APPLY GM MATERIAL BEFORE IT WAS FOUND", MessageType.Error);
        }
        #endregion
    }
}
