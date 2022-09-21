using UnityEngine;

public class OWCamera : MonoBehaviour
{
	[SerializeField]
	protected bool _useFarCamera;
	[SerializeField]
	protected float _farCameraDist;
	[SerializeField]
	protected bool _renderSkybox;
	[SerializeField]
	protected bool _useViewmodels;
	[SerializeField]
	protected float _viewmodelFOV;
}
