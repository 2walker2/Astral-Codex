using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AstralCodex
{
    internal class HideMinimapTrigger : MonoBehaviour
    {

        #region Variables
        PlanetoidRuleset ruleset; //The ruleset the controls the minimap
        #endregion

        #region Initialize
        void Start()
        {
            ruleset = transform.root.GetComponentInChildren<PlanetoidRuleset>();
        }
        #endregion

        #region Enter/Exit Collider
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
                ruleset._useMinimap = false;
        }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
                ruleset._useMinimap = true;
        }
        #endregion
    }
}
