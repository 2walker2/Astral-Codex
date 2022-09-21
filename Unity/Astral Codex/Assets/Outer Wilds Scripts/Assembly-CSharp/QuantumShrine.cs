using UnityEngine;

public class QuantumShrine : SocketedQuantumObject
{
	[SerializeField]
	private Light _ambientLight;
	[SerializeField]
	private Light[] _lamps;
	[SerializeField]
	private FogOverrideVolume _fogOverride;
	[SerializeField]
	private OWTriggerVolume _triggerVolume;
	[SerializeField]
	private NomaiGateway _gate;
	[SerializeField]
	private MeshRenderer _floorRenderer;
	[SerializeField]
	private Material[] _floorMaterials;
	[SerializeField]
	private QuantumSocket _northSocket;
	[SerializeField]
	private GameObject _eyeStateDoorPlug;
	[SerializeField]
	private OWRenderer _exteriorRenderer;
	[SerializeField]
	private NomaiInterfaceOrb[] _childOrbs;
	[SerializeField]
	private OWLightController _exteriorLightController;
}
