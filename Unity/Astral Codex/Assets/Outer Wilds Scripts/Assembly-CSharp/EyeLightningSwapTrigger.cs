using UnityEngine;

public class EyeLightningSwapTrigger : MonoBehaviour
{
	[SerializeField]
	private GameObject _quantumLightningObjectRoot;
	[SerializeField]
	private CloudLightningGenerator[] _lightningGenerators;
	[SerializeField]
	private OWLight _ambientLight;
	[SerializeField]
	private OWLight _cloudEdgeLight;
}
