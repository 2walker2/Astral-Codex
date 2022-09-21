using UnityEngine;
using System.Collections.Generic;

public class LightCodeReader : MonoBehaviour
{
	[SerializeField]
	private LightCodeName _codeName;
	[SerializeField]
	private bool _reverses;
	[SerializeField]
	private float _pauseDuration;
	[SerializeField]
	private GameObject _lightsRoot;
	[SerializeField]
	private List<NomaiLamp> _lights;
}
