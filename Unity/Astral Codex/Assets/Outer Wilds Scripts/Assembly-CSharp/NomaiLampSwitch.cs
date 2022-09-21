using UnityEngine;

public class NomaiLampSwitch : MonoBehaviour
{
	[SerializeField]
	private bool _startOn;
	[SerializeField]
	private float _fadeDuration;
	[SerializeField]
	private GameObject _lampRoot;
	[SerializeField]
	private TractorBeamController[] _tractorBeams;
	[SerializeField]
	private NomaiInterfaceSlot[] _onSlots;
	[SerializeField]
	private NomaiInterfaceSlot[] _offSlots;
	[SerializeField]
	private NomaiInterfaceSlot[] _toggleSlots;
}
