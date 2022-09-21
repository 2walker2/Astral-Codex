using UnityEngine;
using System.Collections.Generic;

public class FragmentIntegrity : MonoBehaviour
{
	[SerializeField]
	protected float _integrity;
	[SerializeField]
	private float _randomIntegrityRange;
	[SerializeField]
	protected float _damageMultiplier;
	[SerializeField]
	private float _minImpactMass;
	[SerializeField]
	private float _maxImpactMass;
	[SerializeField]
	private float _minImpactSpeed;
	[SerializeField]
	private float _maxImpactSpeed;
	[SerializeField]
	private List<FragmentIntegrity> _childFragmentList;
	[SerializeField]
	private bool _breakWithLastChild;
	[SerializeField]
	private bool _ignoreMeteorDamage;
}
