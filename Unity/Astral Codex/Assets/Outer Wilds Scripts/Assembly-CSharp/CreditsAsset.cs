using UnityEngine;

public class CreditsAsset : ScriptableObject
{
	public TextAsset xml;
	public GameObject fadeSectionTemplate;
	public GameObject scrollSectionTemplate;
	public GameObject lineSpacerTemplate;
	[SerializeField]
	private TemplateDictionary _templates;
	[SerializeField]
	private string _xmlText;
}
