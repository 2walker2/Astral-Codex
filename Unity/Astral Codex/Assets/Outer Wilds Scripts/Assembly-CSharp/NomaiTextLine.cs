using UnityEngine;

public class NomaiTextLine : MonoBehaviour
{
	[SerializeField]
	private int _entryID;
	[SerializeField]
	private Vector3[] _points;
	[SerializeField]
	private bool _prebuilt;
	[SerializeField]
	private float[] _lengths;
	[SerializeField]
	private float _totalLength;
	[SerializeField]
	private Vector3 _center;
	[SerializeField]
	private float _radius;
}
