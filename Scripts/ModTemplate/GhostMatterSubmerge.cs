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
        SphereShape ghostMatterCollider;
        SphereShape ghostMatterNotification;
        GameObject signal;

        void Start()
        {
            ghostMatterCollider = SearchUtilities.Find("StationGhostMatter").GetComponent<SphereShape>();
            //if (ghostMatterCollider != null) Main.modHelper.Console.WriteLine($"FOUND GHOST MATTER COLLIDER", MessageType.Success);
            ghostMatterNotification = SearchUtilities.Find("StationGhostMatter/NotificationVolume").GetComponent<SphereShape>();
            ghostMatterNotification.radius = 75;
            ghostMatterNotification.enabled = true;
            ghostMatterCollider.enabled = true;
            signal = SearchUtilities.Find("Chime Signal");
        }

        void Update()
        {
            if (Locator.GetDeathManager().IsPlayerDying())
                signal.SetActive(false);
                
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("PlayerDetector"))
            {
                ghostMatterCollider.enabled = false;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("PlayerDetector"))
            {
                ghostMatterCollider.enabled = true;
            }
        }

    }
}
