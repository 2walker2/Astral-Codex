using UnityEngine;

public class DetachableFragment : MonoBehaviour
{
	public enum ForceMask
	{
		Everything = 0,
		SunOnly = 1,
		ParentOnly = 2,
	}

	[SerializeField]
	private GameObject _destructibleRoot;
	[SerializeField]
	private float _destructibleDelay;
	[SerializeField]
	private Vector3 _localCenterOfMass;
	[SerializeField]
	private Transform _centerOfMassOverride;
	[SerializeField]
	private float _mass;
	[SerializeField]
	private float _drag;
	[SerializeField]
	private ForceMask _forceDetection;
	[SerializeField]
	private Vector3 _fragmentBoundSize;
	[SerializeField]
	private bool _makeKinematic;
	[SerializeField]
	private bool _addShapeToDetector;
	[SerializeField]
	private float _detectorRadius;
	[SerializeField]
	private bool _drawBounds;
	[SerializeField]
	private bool _muteAudio;
	[SerializeField]
	private AudioType _overrideDefaultAudio;
	[SerializeField]
	private OWAudioSource _audioSource;
}
