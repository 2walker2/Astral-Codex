using UnityEngine;

namespace UnityEngine.UI
{
	public class TextStyleApplier : BaseMeshEffect
	{
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[SerializeField]
		private bool useRichText;
		[SerializeField]
		private float m_spacing;
		[SerializeField]
		private Font m_font;
		[SerializeField]
		private float m_fixedWidth;
		[SerializeField]
		private LayoutElement parentOverrideLayoutElement;
	}
}
