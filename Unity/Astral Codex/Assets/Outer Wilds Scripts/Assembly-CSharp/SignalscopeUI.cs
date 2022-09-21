using UnityEngine;
using UnityEngine.UI;

public class SignalscopeUI : MonoBehaviour
{
	[SerializeField]
	private Canvas _signalscopeCanvas;
	[SerializeField]
	private LineRenderer _waveformRenderer;
	[SerializeField]
	private Image _leftBoundLine;
	[SerializeField]
	private Image _rightBoundLine;
	[SerializeField]
	private Text _signalscopeLabel;
	[SerializeField]
	private float _amplitude;
	[SerializeField]
	private bool _showFrequencyLabel;
	[SerializeField]
	private Text _distanceLabel;
	[SerializeField]
	private RectTransform _signalZoomArrow;
	[SerializeField]
	private float _signalZoomArrowStartRot;
	[SerializeField]
	private float _signalZoomArrowEndRot;
	[SerializeField]
	private bool _isPlayerScope;
	[SerializeField]
	private Canvas _signalZoomGroup;
}
