using UnityEngine;

public class MapTest : MonoBehaviour
{
	[SerializeField]
	private GhostNodeMap _map;
	[SerializeField]
	private bool _check;
	[SerializeField]
	private bool _editorChecks;
	[SerializeField]
	private float _speed;
	[SerializeField]
	private float _maxDist;
	[SerializeField]
	private bool _visitOrderColors;
	[SerializeField]
	private bool _turnScoreColors;
	[SerializeField]
	private bool _printTurnScores;
}
