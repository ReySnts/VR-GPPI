using UnityEngine;

public interface IAnimator
{
    public abstract Animator Animator { get; }

    public abstract RuntimeAnimatorController AnimatorController { get; }
}