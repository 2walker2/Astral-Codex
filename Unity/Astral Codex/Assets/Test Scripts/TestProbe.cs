using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProbe : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;

    private void OnTriggerEnter(Collider other)
    {
        transform.parent = other.transform;
        rigid.useGravity = false;
        rigid.isKinematic = true;
    }
}
