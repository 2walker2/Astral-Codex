using UnityEngine;

public class SwitchLightCastShadowSceneOptimization : MonoBehaviour
{
	public bool skip;
	public Light[] sceneLightComponents;
	public Light[] prefabLightComponents;
	public bool operateOnPrefabLights;
	public bool disableShadows;
}
