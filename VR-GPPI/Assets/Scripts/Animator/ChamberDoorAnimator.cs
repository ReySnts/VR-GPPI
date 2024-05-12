using UnityEngine;

public class ChamberDoorAnimator : MonoBehaviour, IAnimator
{
    [field: SerializeField] public Animator Animator { get; private set; }

    [field: SerializeField] public RuntimeAnimatorController AnimatorController { get; private set; }
}