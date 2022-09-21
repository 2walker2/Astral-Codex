using System;
using UnityEngine;

[Serializable]
public class Slide
{
	public Texture2D _image;
	public bool expanded;
	[SerializeField]
	private int _modulesList;
	[SerializeField]
	private ushort[] lengths;
	[SerializeField]
	private byte[] _modulesData;
	[SerializeField]
	private int _streamingImageID;
}
