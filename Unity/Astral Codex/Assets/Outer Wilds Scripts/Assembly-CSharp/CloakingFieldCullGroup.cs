using UnityEngine;

public class CloakingFieldCullGroup : CullGroup
{
	[SerializeField]
	protected CloakFieldController _cloakingField;
	[SerializeField]
	protected Sector _exclusiveSector;
}
