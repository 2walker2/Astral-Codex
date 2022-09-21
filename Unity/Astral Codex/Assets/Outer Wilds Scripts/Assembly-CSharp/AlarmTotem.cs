using UnityEngine;

public class AlarmTotem : SectoredMonoBehaviour
{
	[SerializeField]
	private Transform _sightOrigin;
	[SerializeField]
	private OWLightController _pulseLightController;
	[SerializeField]
	private float _sightDistance;
	[SerializeField]
	private float _sightAngle;
	[SerializeField]
	private Transform _leftFaceCover;
	[SerializeField]
	private Transform _rightFaceCover;
	[SerializeField]
	private bool _isTutorialTotem;
	[SerializeField]
	private Renderer _simTotemRenderer;
	[SerializeField]
	private Material _simAlarmMaterial;
	[SerializeField]
	private OWRenderer _simVisionConeRenderer;
	[SerializeField]
	private Color _simAlarmColor;
}
