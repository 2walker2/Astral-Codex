using UnityEngine;

public class InteractReceiver : SingleInteractionVolume
{
	[SerializeField]
	protected float _interactRange;
	[SerializeField]
	private bool _checkViewAngle;
	[SerializeField]
	private float _maxViewAngle;
	[SerializeField]
	private bool _usableInShip;
}
