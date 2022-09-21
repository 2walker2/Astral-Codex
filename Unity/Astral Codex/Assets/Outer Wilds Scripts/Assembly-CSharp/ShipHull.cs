using UnityEngine;

public class ShipHull : MonoBehaviour
{
	public enum Section
	{
		Top = 0,
		Bottom = 1,
		Left = 2,
		Right = 3,
		Front = 4,
		Back = 5,
	}

	[SerializeField]
	protected UITextType _hullName;
	[SerializeField]
	protected Section _section;
	[SerializeField]
	protected GameObject _collidersGroup;
	[SerializeField]
	protected GameObject _componentsGroup;
	[SerializeField]
	protected DamageEffect _damageEffect;
	[SerializeField]
	protected float _repairTime;
}
