using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnMaterialBlue : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
