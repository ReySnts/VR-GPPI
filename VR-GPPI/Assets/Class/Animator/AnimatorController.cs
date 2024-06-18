using UnityEngine;

public class AnimatorController : AnimatorTemplate, IAnimatorController
{
    [field: SerializeField] public Animator Animator { get; private set; }

    [field: SerializeField] public RuntimeAnimatorController RuntimeAnimatorController { get; private set; }

    protected override void Play(string animatorParameter)
    {
        Animator.runtimeAnimatorController = RuntimeAnimatorController;
        Animator.Play(animatorParameter);
    }
}