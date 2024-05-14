using UnityEngine;

public interface IAnimatorController : IAnimator
{
    public abstract RuntimeAnimatorController RuntimeAnimatorController { get; }
}