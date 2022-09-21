using UnityEngine;

public class CapsuleShape : Shape
{
	[SerializeField]
	protected Vector3 _center;
	[SerializeField]
	protected float _radius;
	[SerializeField]
	protected float _height;
	[SerializeField]
	protected int _direction;
}
