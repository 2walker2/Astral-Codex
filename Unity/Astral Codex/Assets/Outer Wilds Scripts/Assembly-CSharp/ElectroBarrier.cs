using UnityEngine;

public class ElectroBarrier : SectoredMonoBehaviour
{
	[SerializeField]
	private float _barrierRadius;
	[SerializeField]
	private float _auraDist;
	[SerializeField]
	private float _staticDist;
	[SerializeField]
	private GameObject _auraPrefab;
	[SerializeField]
	private GameObject _staticPrefab;
}
