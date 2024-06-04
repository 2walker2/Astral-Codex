using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AstralCodex
{
    internal class ProbeDestroyOnExitVolume : EffectVolume
    {
        public override void OnEffectVolumeEnter(GameObject hitObj)
        {
            ProbeDestructionDetector component = hitObj.GetComponent<ProbeDestructionDetector>();
            if (component != null)
            {
                component.RemoveVolume(this);
            }
        }

        public override void OnEffectVolumeExit(GameObject hitObj)
        {
            ProbeDestructionDetector component = hitObj.GetComponent<ProbeDestructionDetector>();
            if (component != null)
            {
                component.AddVolume(this);
            }
        }
    }
}
