using UnityEngine;

public class SwitchShadowCasterSceneOptimization : MonoBehaviour
{
	public bool skip;
	public bool disableAllShadowCasting;
	public Vector3 minBoundsSize;
	public float minBoundsVolume;
	public string[] nameSearchStrings;
	public string[] shaderSearchStrings;
	public bool disableProbeBlending;
	public bool disableLightProbes;
	public bool disableParticleShadows;
	public GameObject[] exceptions;
}
