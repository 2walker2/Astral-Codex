using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TesseractActivationTest : MonoBehaviour
{
    [SerializeField] MeshRenderer render;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            render.material.SetFloat("_StartTime", Time.time);
        }
    }
}
