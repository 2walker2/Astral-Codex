using UnityEngine;

public class Shape : MonoBehaviour
{
	public enum CollisionMode
	{
		Volume = 0,
		Detector = 1,
		Manual = 2,
	}

	public enum Layer
	{
		Default = 1,
		Sector = 2,
		Gravity = 4,
		Light = 8,
	}

	[SerializeField]
	protected CollisionMode _collisionMode;
	[SerializeField]
	protected Layer _layer;
	[SerializeField]
	protected int _layerMask;
	[SerializeField]
	protected bool _pointChecksOnly;
}
