using UnityEngine;
using UnityEngine.UI;

public class SleepTimerUI : MonoBehaviour
{
	[SerializeField]
	private Canvas _canvas;
	[SerializeField]
	private Text _text;
	[SerializeField]
	private Transform _emberRoot;
	[SerializeField]
	private Vector2 _emberDelay;
	[SerializeField]
	private Vector2 _constantForce;
	[SerializeField]
	private Vector2 _noiseForce;
	[SerializeField]
	private Vector2 _noiseScreenScale;
	[SerializeField]
	private Vector2 _noiseTimeScale;
	[SerializeField]
	private Vector2 _randomScale;
	[SerializeField]
	private Gradient _randomTint;
	[SerializeField]
	private Gradient _dreamFireRandomTint;
	[SerializeField]
	private Vector2 _heatVelRange;
	[SerializeField]
	private Gradient _heatTint;
	[SerializeField]
	private Gradient _dreamFireHeatTint;
	[SerializeField]
	private Material _defaultEmberMaterial;
	[SerializeField]
	private Material _dreamEmberMaterial;
}
