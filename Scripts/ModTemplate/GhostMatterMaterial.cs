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
        #region Variables
        const string MaterialName = "ghostMatterCrystal"; //The name of the material to get from the AssetHandler

        //Renderers to not apply the material to
        static List<string> renderersToExclude = new List<string>()
        {
            "ring_text_glow",
            "Arc",
            "ShellLaticeFilled",
            "ShellLatice",
            "Ring1", "Ring2", "Ring3", "Ring4", "Ring5", "Ring6", "Ring7"
        };
        
        List<Renderer> renderers; //The mesh renderers on this object and its children
        #endregion

        #region Apply Material
        void Start()
        {
            renderers = new List<Renderer>(GetComponentsInChildren<Renderer>());
            NewHorizons.Utility.OWML.Delay.FireOnNextUpdate(ApplyMaterial);
        }

        void ApplyMaterial()
        {
            //Apply the material to this object
            if (renderers != null && renderers.Count > 0)
            {
                foreach (Renderer r in renderers)
                {
                    Material material = AssetHandler.materials[MaterialName];
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
        #endregion
    }
}
