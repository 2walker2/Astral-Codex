using UnityEngine;

public class LandingCameraDashboardRenderer : MonoBehaviour
{
	private enum RenderTime
	{
		Early = 0,
		Mid = 1,
		Late = 2,
	}

	[SerializeField]
	private RenderTime _renderTime;
	[SerializeField]
	private Material[] _materials;
}
