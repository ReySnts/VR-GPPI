using UnityEngine;

public interface IAnimator
{
    public abstract Animator Animator { get; set; }

    public abstract RuntimeAnimatorController AnimatorController { get; set; }
}