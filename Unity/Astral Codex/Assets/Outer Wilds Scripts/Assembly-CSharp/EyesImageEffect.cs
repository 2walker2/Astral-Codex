using UnityEngine;

public class EyesImageEffect : MonoBehaviour
{
	[SerializeField]
	private Shader _eyesShader;
	[SerializeField]
	private Texture2D _eyesTexture;
	[SerializeField]
	private float _openness;
	[SerializeField]
	private float _blendWidth;
}
