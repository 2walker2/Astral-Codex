using UnityEngine;
using UnityEngine.Rendering;

public class PerSectorShadowCastingStateGroup : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private ShadowCastingMode _shadowCastingMode;
}
