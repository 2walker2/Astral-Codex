using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

namespace AstralCodex
{
    class GhostMatterMaterial : MonoBehaviour
    {
        //static Material material;
        List<MeshRenderer> renderers;
        static List<string> renderersToExclude;

        void Start()
        {
            renderers = new List<MeshRenderer>(GetComponentsInChildren<MeshRenderer>());
            if (renderersToExclude == null)
            {
                renderersToExclude = new List<string>()
                {
                    "ring_text_glow",
                    "Arc"
                };
            }
        }

        void Update()
        {
            /*if (material == null)
            {
                GameObject ghostMatterClutter = GameObject.Find("TimberHearth_Body/Sector_TH/Sector_NomaiCrater/DetailPatches_NomaiCrater/NomaiCrater Foliage/Props_GhostMatter/Props_GM_Clutter");
                if (ghostMatterClutter != null)
                    material = ghostMatterClutter.GetComponent<MeshRenderer>().material;
            }
            else
            {*/
                if (renderers != null && renderers.Count > 0)
                {
                    List<MeshRenderer> renderersToRemove = new List<MeshRenderer>();
                    foreach (MeshRenderer r in renderers)
                    {
                        if (r.material != Main.instance.ghostMatterMaterial)
                        {
                            if (!renderersToExclude.Contains(r.gameObject.name))
                            {
                                r.material = Main.instance.ghostMatterMaterial;
                            }
                            r.gameObject.layer = 22;
                            renderersToRemove.Add(r);
                        }
                    }
                    foreach (MeshRenderer r in renderersToRemove)
                        renderers.Remove(r);
                }
            //}
        }
    }
}
