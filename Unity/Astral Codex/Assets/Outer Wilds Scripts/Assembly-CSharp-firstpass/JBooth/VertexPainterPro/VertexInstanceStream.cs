using UnityEngine;
using System.Collections.Generic;

namespace JBooth.VertexPainterPro
{
	public class VertexInstanceStream : MonoBehaviour
	{
		[SerializeField]
		private Color[] _colors;
		[SerializeField]
		private List<Vector4> _uv0;
		[SerializeField]
		private List<Vector4> _uv1;
		[SerializeField]
		private List<Vector4> _uv2;
		[SerializeField]
		private List<Vector4> _uv3;
		[SerializeField]
		private Vector3[] _positions;
		[SerializeField]
		private Vector3[] _normals;
		[SerializeField]
		private Vector4[] _tangents;
	}
}
