using UnityEngine;

public class DoorUnlockingState : DoorState
{
    private float currentTime;

    public override void Enter() => currentTime = Time.time;

    public override void DoUpdate()
    {
        var animationDuration = 1f;
        if (Time.time >= currentTime + animationDuration) stateMachine.TransitionTo(stateMachine.UnlockedState);
    }

    public override void Exit() => door.Animator.StopPlayback();
}