using UnityEngine;
using UnityEngine.PostProcessing;

public class Peephole : MonoBehaviour
{
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private OWCamera _peepholeCamera;
	[SerializeField]
	private PostProcessingBehaviour _peepholeCameraPostProcessing;
	[SerializeField]
	private Sector _viewingSector;
	[SerializeField]
	private float _enterTransitionInLength;
	[SerializeField]
	private float _exitTransitionOutLength;
	[SerializeField]
	private float _exitZoomOutLength;
	[SerializeField]
	private float _enterCloseEyesLength;
	[SerializeField]
	private float _enterOpenEyesLength;
	[SerializeField]
	private float _exitCloseEyesLength;
	[SerializeField]
	private float _exitOpenEyesLength;
	[SerializeField]
	private string[] _factIDs;
}
