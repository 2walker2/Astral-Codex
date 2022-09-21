using UnityEngine;

public class UnderwaterCurrentFadeController : SectoredMonoBehaviour
{
	[SerializeField]
	private float _minAlpha;
	[SerializeField]
	private float _minDistance;
	[SerializeField]
	private float _maxDistance;
	[SerializeField]
	private OWRenderer[] _currentRenderers;
}
