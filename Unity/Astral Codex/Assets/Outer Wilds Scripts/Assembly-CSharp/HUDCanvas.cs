using UnityEngine;
using UnityEngine.UI;

public class HUDCanvas : MonoBehaviour
{
	[SerializeField]
	private ScreenPromptList _boostPromptList;
	[SerializeField]
	private Camera _hudCamera;
	[SerializeField]
	private Color _normalLevelColor;
	[SerializeField]
	private Color _warningLevelColor;
	[SerializeField]
	private Color _dangerLevelColor;
	[SerializeField]
	private Color _boostRechargingColor;
	[SerializeField]
	private Image _boostSliderFillImage;
	[SerializeField]
	private Image _fuelGaugeImage;
	[SerializeField]
	private Image _oxyGaugeImage;
	[SerializeField]
	private Image _boostSliderBGImage;
	[SerializeField]
	private Image _healthDisplayImage;
	[SerializeField]
	private float _lowBoostPercent;
	[SerializeField]
	private float _lowerBoostPercent;
	[SerializeField]
	private GameObject _boostArrowIndicator;
	[SerializeField]
	private GameObject _fuelArrowIndicator;
	[SerializeField]
	private GameObject _oxyArrowIndicator;
	[SerializeField]
	private Transform _boostValueDisplayRoot;
	[SerializeField]
	private Text _boostValueDisplay;
	[SerializeField]
	private Text _fuelValueDisplay;
	[SerializeField]
	private Text _oxyValueDisplay;
	[SerializeField]
	private GameObject _gForceRoot;
	[SerializeField]
	private Text _gForceDisplay;
	[SerializeField]
	private SignalscopeUI _hudSignalscopeUI;
	[SerializeField]
	private SignalscopeUI _nonHudSignalscopeUI;
	[SerializeField]
	private Signalscope _signalscopeTool;
	[SerializeField]
	private ThrustAndAttitudeIndicator _thrusterIndicator;
	[SerializeField]
	private ProbeLauncherUI _hudProbeLauncherUI;
}
