using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

namespace AstralCodex
{
    class Rotate : MonoBehaviour
    {
        public Vector3 speed;

        void Update()
        {
            transform.Rotate(speed * Time.deltaTime);
        }
    }
}
