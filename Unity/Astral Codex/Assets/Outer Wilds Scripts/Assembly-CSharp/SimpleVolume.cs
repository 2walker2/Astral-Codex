using UnityEngine;

public class SimpleVolume : MonoBehaviour
{
	public enum Shape
	{
		Sphere = 0,
		Capsule = 1,
		Box = 2,
	}

	[SerializeField]
	protected Shape _shape;
	[SerializeField]
	protected float _radius;
	[SerializeField]
	protected float _height;
	[SerializeField]
	protected Vector3 _size;
}
