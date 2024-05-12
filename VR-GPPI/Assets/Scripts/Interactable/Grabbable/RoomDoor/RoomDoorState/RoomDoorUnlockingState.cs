using UnityEngine;

public class RoomDoorUnlockingState : DoorState<ISensorDoor>, IStateComplete
{
    [SerializeField] private Animator animator;

    [SerializeField] private RoomDoorUnlockedState unlockedState;

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
            stateMachine.TransitionTo(unlockedState);
        }
    }

    public void Exit() => animator.enabled = false;
}