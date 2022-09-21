using UnityEngine;

public class CharacterLightingRigController : SectoredMonoBehaviour
{
	[SerializeField]
	private OWRenderer[] _characterRenderers;
	[SerializeField]
	private Color _skyLightColor;
	[SerializeField]
	private Vector3 _skyLightDir;
	[SerializeField]
	private Color _bounceLightColor;
	[SerializeField]
	private Vector3 _bounceLightDir;
	[SerializeField]
	private Color _rimLightColor;
	[SerializeField]
	private Vector3 _rimLightDir;
	[SerializeField]
	private Vector3 _falloffCenter;
	[SerializeField]
	private float _falloffRadius;
}
