using UnityEngine;

public class OldGrowthForestController : MonoBehaviour
{
	[SerializeField]
	private PlayerCloneController _playerClone;
	[SerializeField]
	private GameObject _treeRoot;
	[SerializeField]
	private GameObject _foliageRoot;
	[SerializeField]
	private Material _quantumMaterial;
	[SerializeField]
	private FluidVolume _airVolume;
	[SerializeField]
	private OWAudioSource _desolateAmbience;
}
