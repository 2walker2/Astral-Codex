using UnityEngine.UI;
using UnityEngine;

namespace UnityEngine.UI.Extensions
{
	public class UILineTextureRenderer : MaskableGraphic
	{
		[SerializeField]
		private Texture m_Texture;
		[SerializeField]
		private Rect m_UVRect;
		public float LineThickness;
		public bool UseMargins;
		public Vector2 Margin;
		public Vector2[] Points;
		public bool relativeSize;
	}
}
