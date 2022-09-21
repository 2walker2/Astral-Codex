using UnityEngine;

public class StreamingGroup : MonoBehaviour
{
	[SerializeField]
	private string _sceneName;
	[SerializeField]
	private StreamingMaterialTable[] _streamingMaterialTables;
	[SerializeField]
	private bool _reloadAssetsOnDeath;
}
