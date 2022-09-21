using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
	[SerializeField]
	private GameObject _prefab;
	[SerializeField]
	private int _spawnCount;
	[SerializeField]
	private bool _spawnOnStart;
}
