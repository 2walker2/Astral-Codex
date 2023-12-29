using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDepthTextureTest : MonoBehaviour
{

    [SerializeField] Camera cameraToCheck;

    // Start is called before the first frame update
    void Start()
    {
        SetDepthTextureMode();
    }

    [ContextMenu("Enable Depth Texture")]
    void SetDepthTextureMode()
    {
        Debug.Log(cameraToCheck.depthTextureMode);
        cameraToCheck.depthTextureMode = DepthTextureMode.Depth;
        Debug.Log(cameraToCheck.depthTextureMode);
    }
}
