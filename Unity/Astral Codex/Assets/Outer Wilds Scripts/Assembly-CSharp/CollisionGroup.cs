using UnityEngine;
using System.Collections.Generic;

public class CollisionGroup : MonoBehaviour
{
	[SerializeField]
	private bool _prebuilt;
	[SerializeField]
	private List<OWCollider> _colliders;
	[SerializeField]
	private List<Shape> _shapes;
}
