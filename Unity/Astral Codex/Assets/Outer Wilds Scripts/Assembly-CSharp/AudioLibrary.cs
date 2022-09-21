using System;
using UnityEngine;

[Serializable]
public class AudioLibrary : ScriptableObject
{
	[Serializable]
	public struct AudioEntry
	{
		public AudioEntry(AudioType t, AudioClip[] c) : this()
		{
		}

		public AudioType type;
		public AudioClip[] clips;
		public float volume;
	}

	public AudioEntry[] audioEntries;
}
