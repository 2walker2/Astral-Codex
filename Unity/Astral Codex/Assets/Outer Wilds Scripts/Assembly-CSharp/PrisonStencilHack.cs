using UnityEngine;

public class PrisonStencilHack : MonoBehaviour
{
	[SerializeField]
	private OWRingRiverCollider _riverCollider;
	[SerializeField]
	private OWRenderer _topStencil;
	[SerializeField]
	private OWRenderer _bottomStencil;
	[SerializeField]
	private float _floodLerpSwapTime;
}
