using UnityEngine;
using UnityEngine.UI;

public class Flickerer : MonoBehaviour
{
	[SerializeField]
	private Color _flickerColor;
	[SerializeField]
	private Text[] _listTextItems;
	[SerializeField]
	private Image[] _listImageItems;
	[SerializeField]
	private MeshRenderer[] _listRenderers;
	[SerializeField]
	private float _flickerTime;
	[SerializeField]
	private bool _flickerOnInstantDamage;
}
