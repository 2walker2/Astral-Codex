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
        const string TimeInputParameter = "_TimeInput"; //The parameter on the material to set to indicate current time of the effect

        float lifetime = 10f; //The total time before this effect is destroyed
        float time; //The time since this object was created
        Material controlledMaterial; //The material this script controls

        void Start()
        {
            //Parent self to the player's camera
            transform.parent = Locator.GetPlayerCamera().transform;
            transform.localPosition = Vector3.zero;
            transform.forward = -transform.parent.right;

            //Get the material to control
            controlledMaterial = GetComponent<MeshRenderer>().material;

            time = 0;
        }

        void Update()
        {
            //Update time
            time += Time.deltaTime;
            if (time > lifetime)
                Destroy(gameObject);

            //Pass time to material
            controlledMaterial.SetFloat(TimeInputParameter, time);
        }
    }
}
