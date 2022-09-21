using System;
using UnityEngine.Events;
using UnityEngine;

public class DistanceTrigger : SectoredMonoBehaviour
{
	[Serializable]
	public class TriggerEnterEvent : UnityEvent
	{
	}

	[Serializable]
	public class TriggerExitEvent : UnityEvent
	{
	}

	[SerializeField]
	protected float _triggerRadius;
	[SerializeField]
	public TriggerEnterEvent OnTriggerEnter;
	[SerializeField]
	public TriggerExitEvent OnTriggerExit;
}
