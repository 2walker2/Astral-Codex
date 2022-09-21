using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class LockOnReticule : MonoBehaviour
{
	[SerializeField]
	private GameObject _reticuleArrowRoot;
	[SerializeField]
	private Transform[] _reticuleArrowPivots;
	[SerializeField]
	private MeshRenderer[] _reticuleArrowMeshes;
	[SerializeField]
	private float _lockOnScalar;
	[SerializeField]
	private GameObject _reticuleLockOnRoot;
	[SerializeField]
	private MeshRenderer[] _reticuleLockOnMeshes;
	[SerializeField]
	private float _highlightScalar;
	[SerializeField]
	private GameObject _reticuleHighlightRoot;
	[SerializeField]
	private MeshRenderer[] _reticuleHighlightMeshes;
	[SerializeField]
	private Transform _readoutScaleRoot;
	[SerializeField]
	private Text _readout;
	[SerializeField]
	private UILineRenderer _lineX;
	[SerializeField]
	private UILineRenderer _lineY;
	[SerializeField]
	private ScreenPromptList _promptListBlock;
}
