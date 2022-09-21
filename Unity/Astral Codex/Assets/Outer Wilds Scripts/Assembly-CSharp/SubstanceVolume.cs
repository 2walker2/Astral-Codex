using UnityEngine;

public class SubstanceVolume : MonoBehaviour
{
	public enum SubstanceType
	{
		Oxygen = 0,
	}

	[SerializeField]
	private SubstanceType _substanceType;
}
