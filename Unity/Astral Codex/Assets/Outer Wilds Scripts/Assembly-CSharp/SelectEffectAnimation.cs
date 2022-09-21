using UnityEngine;

public class SelectEffectAnimation : SelectEffect
{
	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private string _animatorOnSelectTrigger;
	[SerializeField]
	private string _animatorOnDeselectTrigger;
}
