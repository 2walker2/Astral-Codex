using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;

public class TrackedDeviceRaycaster : BaseRaycaster
{
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	public override Camera eventCamera
	{
		get { return default(Camera); }
	}

	[SerializeField]
	private bool m_IgnoreReversedGraphics;
	[SerializeField]
	private bool m_CheckFor2DOcclusion;
	[SerializeField]
	private bool m_CheckFor3DOcclusion;
	[SerializeField]
	private float m_MaxDistance;
	[SerializeField]
	private LayerMask m_BlockingMask;
}
