using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using NewHorizons.Builder;
using NewHorizons.Utility;

namespace AstralCodex
{
    class TesseractActivationEffect : MonoBehaviour
    {
        const string StartTimeParameter = "_StartTime"; //The parameter on the material to set to indicate the start time of the effect

        float lifetime = 10f; //The total time before this effect is destroyed

        void Start()
        {
            //Parent self to the player's camera
            transform.parent = Camera.main.transform;
            transform.localPosition = Vector3.zero;

            //Set the material's start time to the current time
            GetComponentInChildren<MeshRenderer>().material.SetFloat(StartTimeParameter, Time.time);

            //Destroy after effect is complete
            Invoke(nameof(DestroySelf), lifetime);
        }

        void DestroySelf()
        {
            Destroy(this);
        }
    }
}
