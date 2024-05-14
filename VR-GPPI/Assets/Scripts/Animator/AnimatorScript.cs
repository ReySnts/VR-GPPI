using UnityEngine;

public class AnimatorScript : AnimatorTemplate, IAnimator
{
    [field: SerializeField] public Animator Animator { get; private set; }

    protected override void Play(string animatorParameter) => Animator.Play(animatorParameter);
}