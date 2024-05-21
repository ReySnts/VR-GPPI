using UnityEngine;

public class ChamberDoorClosingState : AnimatedDoorEnterableState, IStateComplete
{
    [SerializeField] private ButtonChamberDoor buttonChamberDoor;

    [SerializeField] private ChamberDoorLockedState lockedState;

    private float currentTime;

    public void Enter()
    {
        currentTime = Time.time;
        statableThing.Notifier.ChangeAll(AnimatorParameter.CLOSE);
    }

    public void DoUpdate()
    {
        var animationDuration = .8f;
        if (Time.time > currentTime + animationDuration)
        {
            Exit();
            stateMachine.TransitionTo(lockedState);
        }
    }

    public void Exit() => buttonChamberDoor.Button.interactable = true;
}