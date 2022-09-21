using UnityEngine;

public class GameObjectActivationTrigger : MonoBehaviour
{
	[SerializeField]
	private bool _checkForTag;
	[SerializeField]
	private string _tag;
	[SerializeField]
	private GameObject[] _gameObjects;
	[SerializeField]
	private bool _fireOnEnter;
	[SerializeField]
	private bool _activeOnEnter;
	[SerializeField]
	private bool _fireOnExit;
	[SerializeField]
	private bool _activeOnExit;
}
