using UnityEngine;

public class WaterMonster : MonoBehaviour
{
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private float _maxAccel;
	[SerializeField]
	private float _maxAccelWithBloodlust;
	[SerializeField]
	private float _maxBloodlust;
	[SerializeField]
	private float _bloodlustCooldown;
	[SerializeField]
	private bool _doesProbeTrigger;
	[SerializeField]
	private SwampFluidVolume _swampVolume;
	[SerializeField]
	private OWTriggerVolume _mouth;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private GameObject _headsRotation;
	[SerializeField]
	private GameObject _tailsRotation;
}
