using UnityEngine;

public class ConeShape : Shape
{
	[SerializeField]
	protected Vector3 _center;
	[SerializeField]
	protected float _topRadius;
	[SerializeField]
	protected float _bottomRadius;
	[SerializeField]
	protected float _height;
	[SerializeField]
	protected int _direction;
}
