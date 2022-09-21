using UnityEngine;
using System;

public class OWIK : MonoBehaviour
{
	[Serializable]
	public struct Constraint
	{
		public float xMidAngle;
		public float xAngle;
		public float yMidAngle;
		public float yAngle;
	}

	[Serializable]
	public struct JointInfo
	{
		public Transform transform;
		public Transform hint;
		public bool useHint;
		public OWIK.Constraint constraint;
		public bool isFixed;
		public bool updatePosition;
		public bool variableLength;
		public Vector2 variableLengthRange;
		public Vector3 manualRotationOffset;
	}

	public enum UpdateCycle
	{
		Update = 0,
		LateUpdate = 1,
		Manual = 2,
	}

	[SerializeField]
	private JointInfo[] _joints;
	[SerializeField]
	private Transform _root;
	[SerializeField]
	private Transform _goal;
	[SerializeField]
	private bool _constrain;
	[SerializeField]
	private UpdateCycle _updateCycle;
	[SerializeField]
	private float _marginOfError;
	[SerializeField]
	private int _iterLimit;
	[SerializeField]
	private float _weight;
	[SerializeField]
	private bool _showConstraints;
}
