using UnityEngine;

public class LandingCamera : MonoBehaviour
{
	[SerializeField]
	private float _aspectRatio;
	[SerializeField]
	private RenderTexture _targetTexture;
	[SerializeField]
	private Shader _landingCamShader;
	[SerializeField]
	private Texture2D _landingCameraLUT;
	[SerializeField]
	private float _landingCameraNoise;
}
