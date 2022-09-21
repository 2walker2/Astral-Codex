using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("NomaiShuttleBody"))
        {
            Debug.Log("SUCCESS!!!!!");
        }
    }
}
