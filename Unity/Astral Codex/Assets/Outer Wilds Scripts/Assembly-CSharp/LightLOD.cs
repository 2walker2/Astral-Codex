using UnityEngine;

public class LightLOD : MonoBehaviour
{
	[SerializeField]
	private bool _fadeShadows;
	[SerializeField]
	private float _shadowFadeStart;
	[SerializeField]
	private float _shadowFadeEnd;
	[SerializeField]
	private bool _disableOnQualitySetting;
	[SerializeField]
	private ShadowQuality _highestQualitySetting;
}
