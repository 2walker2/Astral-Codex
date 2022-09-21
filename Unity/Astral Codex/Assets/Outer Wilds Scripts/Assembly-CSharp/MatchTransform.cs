using UnityEngine;

public class MatchTransform : MonoBehaviour
{
	[SerializeField]
	private Transform _targetTransform;
	[SerializeField]
	private bool _matchPosition;
	[SerializeField]
	private bool _matchRotation;
	[SerializeField]
	private bool _matchLocal;
	[SerializeField]
	private bool _doNotReparent;
}
