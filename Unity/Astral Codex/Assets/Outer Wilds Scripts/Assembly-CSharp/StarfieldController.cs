using UnityEngine;
using System;
using Starfield;

public class StarfieldController : MonoBehaviour
{
	[Serializable]
	private struct StarLookup
	{
		public StarLookup(int groupIndex, int starIndex) : this()
		{
		}

		public int groupIndex;
		public int starIndex;
	}

	[SerializeField]
	private StarfieldData _starfieldData;
	[SerializeField]
	private Renderer _starfieldRenderer;
	[SerializeField]
	private GameObject _supernovaPrefab;
	[SerializeField]
	private GameObject _eyeSupernovaPrefab;
	[SerializeField]
	private Transform _eyeSupernovaSpawnPos;
	[SerializeField]
	private Renderer _dreamStarfieldRenderer;
	[SerializeField]
	private StarLookup[] _orderedStarIndices;
}
