using UnityEngine;

public class ChamberDoorClosingState : DoorState<IAnimatedDoor>, IStateComplete
{
    [SerializeField] private ButtonFunctionKeys buttonFunctionKeys;

    [SerializeField] private ChamberDoorLockedState lockedState;

    private float currentTime;

    public void Enter()
    {
        currentTime = Time.time;
        door.Notifier.Change(AnimatorParameter.CLOSE);
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

    public void Exit() => buttonFunctionKeys.Button.interactable = true;
}