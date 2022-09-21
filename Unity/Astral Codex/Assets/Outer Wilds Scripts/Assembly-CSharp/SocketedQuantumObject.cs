using UnityEngine;
using System.Collections.Generic;

public class SocketedQuantumObject : QuantumObject
{
	[SerializeField]
	private Vector3 _localOffset;
	[SerializeField]
	private float _newlyObscuredSocketProbability;
	[SerializeField]
	private QuantumSocket[] _sockets;
	[SerializeField]
	private GameObject _socketRoot;
	[SerializeField]
	private bool _alignWithGravity;
	[SerializeField]
	private bool _alignWithSocket;
	[SerializeField]
	private bool _randomYRotation;
	[SerializeField]
	private bool _prebuilt;
	[SerializeField]
	private List<QuantumSocket> _socketList;
	[SerializeField]
	private List<QuantumSocket> _childSockets;
}
