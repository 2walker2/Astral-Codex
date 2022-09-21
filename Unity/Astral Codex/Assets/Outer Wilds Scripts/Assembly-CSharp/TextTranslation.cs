using UnityEngine;

public class TextTranslation : MonoBehaviour
{
	public enum Language
	{
		UNKNOWN = -1,
		ENGLISH = 0,
		SPANISH_LA = 1,
		GERMAN = 2,
		FRENCH = 3,
		ITALIAN = 4,
		POLISH = 5,
		PORTUGUESE_BR = 6,
		JAPANESE = 7,
		RUSSIAN = 8,
		CHINESE_SIMPLE = 9,
		KOREAN = 10,
		TURKISH = 11,
		TOTAL = 12,
	}

	public Font[] m_fonts;
	public Font[] m_dynamicFonts;
	public Font[] m_languageFonts;
	public float[] m_defaultSpacing;
	public float[] m_fontSizeModifier;
}
