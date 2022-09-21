using UnityEngine;

public class AnglerfishAnimController : MonoBehaviour
{
	[SerializeField]
	private AnglerfishController _anglerfishController;
	[SerializeField]
	private float _moveChangeSpeed;
	[SerializeField]
	private float _jawOpenSpeed;
	[SerializeField]
	private float _jawCloseSpeed;
	[SerializeField]
	private float _spinesFlareSpeed;
	[SerializeField]
	private float _spinesFlareVariation;
	[SerializeField]
	private Transform[] _spines;
	[SerializeField]
	private float _lookSpeed;
}
