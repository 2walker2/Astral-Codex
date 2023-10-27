using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

namespace AstralCodex
{
    class Rotate : MonoBehaviour
    {
        #region Public Variables
        public Vector3 speed; //The speed the object should rotate about each axis
        #endregion

        #region Rotate
        void Update()
        {
            transform.Rotate(speed * Time.deltaTime);
        }
        #endregion
    }
}
