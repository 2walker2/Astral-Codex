using System;
using UnityEngine;

[Serializable]
public class SlideCollection
{
	public SlideCollection(int startArrSize)
	{
	}

	[SerializeField]
	public string streamingAssetIdentifier;
	[SerializeField]
	public Slide[] slides;
}
