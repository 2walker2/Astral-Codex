using UnityEngine;

public class NomaiVesselComputerRing : MonoBehaviour
{
	[SerializeField]
	private OWRenderer _ringRenderer;
	[SerializeField]
	private OWRenderer _projectorRenderer;
	[SerializeField]
	private float _radius;
	[SerializeField]
	private float _spinSpeedMin;
	[SerializeField]
	private float _spinSpeedMax;
	[SerializeField]
	private float _flickerLength;
	[SerializeField]
	private float _colorFadeTime;
}
