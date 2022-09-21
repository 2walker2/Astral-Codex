using UnityEngine;

public class UrchinCactus : MonoBehaviour
{
	[SerializeField]
	private float _retractedRadius;
	[SerializeField]
	private float _extendedRadius;
	[SerializeField]
	private bool _previewExtended;
	[SerializeField]
	private GameObject _urchinModel;
	[SerializeField]
	private SphereCollider _hazardCollider;
	[SerializeField]
	private SphereCollider _physicalCollider;
	[SerializeField]
	private SandLevelController _sandSphere;
}
