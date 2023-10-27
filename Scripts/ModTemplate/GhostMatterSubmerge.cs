using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using NewHorizons.Utility;

namespace AstralCodex
{
    class GhostMatterSubmerge : MonoBehaviour
    {
        #region Private Variables
        SphereShape ghostMatterCollider; //The ghost matter's kill zone collider
        SphereShape ghostMatterNotification; //The notification volume of the collider
        GameObject signal; //The signal at the center of the ghost matter
        #endregion

        #region Initialization
        void Start()
        {
            ghostMatterCollider = SearchUtilities.Find("StationGhostMatter").GetComponent<SphereShape>();
            //if (ghostMatterCollider != null) Main.modHelper.Console.WriteLine($"FOUND GHOST MATTER COLLIDER", MessageType.Success);
            ghostMatterNotification = SearchUtilities.Find("StationGhostMatter/NotificationVolume").GetComponent<SphereShape>();
            ghostMatterNotification.radius = 75; //Increase notification radius
            ghostMatterNotification.enabled = true;
            ghostMatterCollider.enabled = true;
            signal = SearchUtilities.Find("Chime Signal");
        }
        #endregion

        #region Disable Signal On Death
        void Update()
        {
            //Disable the signal when the player dies to prevent posthumous identification
            if (Locator.GetDeathManager().IsPlayerDying())
                signal.SetActive(false);
        }
        #endregion

        #region Toggle Kill Zone
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("PlayerDetector"))
            {
                //The player is in the water, disable the ghost matter collider
                ghostMatterCollider.enabled = false;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("PlayerDetector"))
            {
                //The player has left the water, enable the ghost matter collider again
                ghostMatterCollider.enabled = true;
            }
        }
        #endregion
    }
}
