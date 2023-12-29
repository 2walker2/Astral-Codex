using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TesseractActivationTest : MonoBehaviour
{
    [SerializeField] MeshRenderer render;
    [SerializeField] ParticleSystem particles;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            render.material.SetFloat("_StartTime", Time.time);
            particles.Play();
        }
    }
}
