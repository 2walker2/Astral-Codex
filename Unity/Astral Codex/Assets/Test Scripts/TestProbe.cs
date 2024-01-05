using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProbe : MonoBehaviour
{
    [SerializeField] GameObject codexDispenser;
    [SerializeField] Rigidbody rigid;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == codexDispenser)
        {
            transform.parent = other.transform;
            rigid.useGravity = false;
            rigid.isKinematic = true;
        }
    }
}
