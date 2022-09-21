using UnityEngine;

public class SinkholeController : MonoBehaviour
{
	[SerializeField]
	private bool _startActivated;
	[SerializeField]
	private MeshRenderer _sinkholeRenderer;
	[SerializeField]
	private int _sinkholeMaterialIndex;
	[SerializeField]
	private float _revealLength;
	[SerializeField]
	private Vector2 _uvScrollSpeed;
	[SerializeField]
	private SandLevelController _sandSphere;
	[SerializeField]
	private float _sandsphereDeactivateHeight;
}
