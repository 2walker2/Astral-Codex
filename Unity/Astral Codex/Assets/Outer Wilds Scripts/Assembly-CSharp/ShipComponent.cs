using UnityEngine;

public class ShipComponent : MonoBehaviour
{
	[SerializeField]
	protected UITextType _componentName;
	[SerializeField]
	protected DamageEffect _damageEffect;
	[SerializeField]
	protected float _repairTime;
	[SerializeField]
	protected AnimationCurve _damageProbabilityCurve;
	[SerializeField]
	protected Collider _repairCollider;
	[SerializeField]
	protected bool _persistentCollider;
	[SerializeField]
	protected bool _internalRepairPoint;
}
