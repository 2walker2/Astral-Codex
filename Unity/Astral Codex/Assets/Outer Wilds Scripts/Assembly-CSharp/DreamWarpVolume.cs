using UnityEngine;

public class DreamWarpVolume : MonoBehaviour
{
	[SerializeField]
	private Transform _destinationTransform;
	[SerializeField]
	private Sector _destinationSector;
	[SerializeField]
	private Transform _loopTransform;
	[SerializeField]
	private OWRenderer _fadeDepartRenderer;
	[SerializeField]
	private float _fadeDepartStartDist;
	[SerializeField]
	private float _fadeDepartEndDist;
	[SerializeField]
	private OWRenderer _fadeArriveRenderer;
	[SerializeField]
	private float _fadeArriveStartDist;
	[SerializeField]
	private float _fadeArriveEndDist;
	[SerializeField]
	private float _fallFadeTriggerDist;
	[SerializeField]
	private OWTriggerVolume _limboVolume;
	[SerializeField]
	private float _fallFadeOutLength;
	[SerializeField]
	private float _fallFadeInLength;
	[SerializeField]
	private Transform _fallDestination;
}
