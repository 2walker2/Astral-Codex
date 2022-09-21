using UnityEngine;
using System.Collections.Generic;

public class FloatingBridgeHovering : MonoBehaviour
{
	[SerializeField]
	private float _hoverHeight;
	[SerializeField]
	private float _risingSpeed;
	[SerializeField]
	private bool _startsHovering;
	[SerializeField]
	private GameObject _detector;
	[SerializeField]
	private List<OWTriggerVolume> _trigger;
}
