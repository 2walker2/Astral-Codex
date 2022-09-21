using UnityEngine;
using System.Collections.Generic;

public class HauntedCandle : MonoBehaviour
{
	[SerializeField]
	private bool _startLit;
	[SerializeField]
	private GameObject _objectsVisibleInLight;
	[SerializeField]
	private GameObject _lightsRoot;
	[SerializeField]
	private List<NomaiLamp> _lights;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private OWLightController _candleLightController;
	[SerializeField]
	private ParticleSystem _candleParticles;
	[SerializeField]
	private GameObject _doorsRoot;
	[SerializeField]
	private List<LightCodeDoor> _doorsToClose;
	[SerializeField]
	public HauntedRoom p_room;
}
