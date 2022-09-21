using UnityEngine;

public class CloakingFieldLightsCullGroup : LightsCullGroup
{
	[SerializeField]
	protected CloakFieldController _cloakingField;
	[SerializeField]
	protected Sector _exclusiveSector;
}
