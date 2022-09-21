using UnityEngine;

public class HazardDetector : Detector
{
	[SerializeField]
	private GameObject _darkMatterEntryEffect;
	[SerializeField]
	private float _darkMatterMinEntrySpeed;
	[SerializeField]
	private ElectricityEffect[] _electricityEffects;
}
