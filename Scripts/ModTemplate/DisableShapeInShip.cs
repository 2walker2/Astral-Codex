using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AstralCodex
{
    internal class DisableShapeInShip : MonoBehaviour
    {
        Shape shape;
        HatchController shipHatch;

        void Start()
        {
            shape = GetComponent<Shape>();
            shipHatch = Locator.GetShipBody().GetComponentInChildren<HatchController>();
        }

        void Update()
        {
            shape.enabled = !shipHatch._isPlayerInShip;
        }
    }
}
