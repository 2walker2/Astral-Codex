using UnityEngine;

public class CloudLightningGenerator : MonoBehaviour
{
	[SerializeField]
	protected float _altitude;
	[SerializeField]
	private Gradient _lightColor;
	[SerializeField]
	private Range _lightIntensity;
	[SerializeField]
	private Range _lightDuration;
	[SerializeField]
	private Range _lightRadius;
	[SerializeField]
	private CloudLightning.AnimSettings[] _lightRandomAnimSettings;
	[SerializeField]
	private LightRenderMode _lightRenderMode;
	[SerializeField]
	private Range _delay;
	[SerializeField]
	private Range _branches;
	[SerializeField]
	protected Range _branchDistance;
	[SerializeField]
	private Range _branchDelay;
	[SerializeField]
	private GameObject _audioPrefab;
	[SerializeField]
	private Sector _audioSector;
}
