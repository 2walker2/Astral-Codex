using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

namespace AstralCodex
{
    [HarmonyPatch]
    internal class Patches
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(DarkBrambleRepelVolume), nameof(DarkBrambleRepelVolume.FixedUpdate))]
        public static bool DarkBrambleRepelVolume_FixedUpdate_Replacement(DarkBrambleRepelVolume __instance)
        {
            for (int i = 0; i < __instance._trackedBodies.Count; i++)
            {
                if (!__instance._trackedBodies[i].CompareTag("Player") || !PlayerState.IsInsideShip())
                {
                    Vector3 planeNormal = __instance.transform.position - __instance._trackedBodies[i].GetPosition();
                    float magnitude = planeNormal.magnitude;
                    Vector3 vector = __instance._trackedBodies[i].GetVelocity() - __instance._parentBody.GetVelocity();
                    float d = Mathf.InverseLerp(__instance._sphereShape.radius, __instance._innerRadius, magnitude);
                    Vector3 velocityChange = (Vector3.ProjectOnPlane(vector, planeNormal).normalized * vector.magnitude - vector) * d;
                    velocityChange.x *= 10;
                    velocityChange.z *= 10;
                    __instance._trackedBodies[i].AddVelocityChange(velocityChange);
                }
            }
            return false;
        }
    }
}
