using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace AstralCodex
{
    class GhostMatterSubmerge : MonoBehaviour
    {

        SphereShape ghostMatterCollider;
        SphereShape ghostMatterNotification;

        void Start()
        {
            ghostMatterCollider = GameObject.Find("StationGhostMatter/DarkMatterVolume").GetComponent<SphereShape>();
            //if (ghostMatterCollider != null) Main.modHelper.Console.WriteLine($"FOUND GHOST MATTER COLLIDER", MessageType.Success);
            ghostMatterNotification = GameObject.Find("StationGhostMatter/DarkMatterVolume/NotificationVolume/ChildShape").GetComponent<SphereShape>();
            ghostMatterNotification.radius = 100;
            ghostMatterNotification.enabled = true;
            ghostMatterCollider.enabled = true;
        }

        void OnTriggerStay(Collider other)
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
