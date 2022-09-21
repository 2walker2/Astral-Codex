using System;
using UnityEngine;

[Serializable]
public struct EntryData
{
	public EntryData(string id, Sprite sprite) : this()
	{
	}

	public string id;
	public Sprite sprite;
	public Sprite altSprite;
	public Vector2 cardPosition;
}
