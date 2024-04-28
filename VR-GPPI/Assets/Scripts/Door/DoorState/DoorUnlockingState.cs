using UnityEngine;

public class DoorUnlockingState : DoorState, IStateComplete
{
    [SerializeField] private Animator animator;

    private float currentTime;

    public void Enter()
    {
        currentTime = Time.time;
        animator.enabled = true;
        //animator.Play(AnimatorParameter.DOOR_UNLOCKING);
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
        //animator.StopPlayback();
        //currentTime = 0f;
    }
}