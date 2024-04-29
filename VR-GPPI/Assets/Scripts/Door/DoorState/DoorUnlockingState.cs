using UnityEngine;

public class DoorUnlockingState : DoorState, IStateComplete
{
    [SerializeField] private Animator animator;

    private float currentTime;

    public void Enter()
    {
        currentTime = Time.time;
        animator.enabled = true;
    }

    public void DoUpdate()
    {
        var animationDuration = 1f;
        if (Time.time > currentTime + animationDuration)
        {
            Exit();
            stateMachine.TransitionTo(stateMachine.UnlockedState);
        }
    }

    public void Exit()
    {
        animator.enabled = false;
        grabLockable.IsLocked = false;
    }
}