using UnityEngine;
using UnityEngine.UI;

public class CanvasMarker : MonoBehaviour
{
	[SerializeField]
	protected Text _mainTextField;
	[SerializeField]
	protected RectTransform _attachPoint;
	[SerializeField]
	protected RectTransform _secondaryLabelRectTransform;
	[SerializeField]
	protected GameObject _dangerIndicatorRootObj;
	[SerializeField]
	protected GameObject _markerWarningImageObj;
	[SerializeField]
	protected Text _secondaryTextField;
	[SerializeField]
	protected RectTransform _dangerIndicatorAttachPoint;
	[SerializeField]
	protected RectTransform _onScreenMarkerRoot;
	[SerializeField]
	protected MeshRenderer _marker;
	[SerializeField]
	protected OffScreenIndicator _offScreenIndicator;
}
