using UnityEngine;

public class Flashlight : MonoBehaviour
{
	[SerializeField]
	private OWLight2[] _lights;
	[SerializeField]
	private OWLight2 _illuminationCheckLight;
	[SerializeField]
	private Transform _root;
	[SerializeField]
	private Transform _basePivot;
	[SerializeField]
	private Transform _wobblePivot;
}
