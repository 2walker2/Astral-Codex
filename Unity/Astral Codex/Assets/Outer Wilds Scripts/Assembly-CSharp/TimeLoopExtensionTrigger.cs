using UnityEngine;

public class TimeLoopExtensionTrigger : MonoBehaviour
{
	[SerializeField]
	private float _rewindToSecondsRemaining;
	[SerializeField]
	private float _extraSecondsInLighthouse;
	[SerializeField]
	private bool _ignoreEarlyEntries;
}
