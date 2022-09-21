using UnityEngine;
using UnityEngine.UI;

public class ProbeLauncherUI : MonoBehaviour
{
	[SerializeField]
	private Canvas _canvas;
	[SerializeField]
	private Image _image;
	[SerializeField]
	private Image _bracketImage;
	[SerializeField]
	private Texture2D _frontSnapshotOverlay;
	[SerializeField]
	private Texture2D _rearSnapshotOverlay;
	[SerializeField]
	private Texture2D _obscuredCameraOverlay;
	[SerializeField]
	private bool _nonSuitUI;
}
