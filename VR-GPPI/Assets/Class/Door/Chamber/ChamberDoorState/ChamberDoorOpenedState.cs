using UnityEngine;

public class ChamberDoorOpenedState : AnimatedDoorEnterableState, IStateComplete
{
    [SerializeField] private ChamberDoorClosingState closingState;

    public void Enter() => statableThing.Handle.Touchable.SimpleInteractable.hoverEntered.AddListener(call => CloseDoor());

    public void DoUpdate()
    {
        var doorOpenable = statableThing.Openable;
        if (!doorOpenable.IsAllowedToOpen && doorOpenable.IsAllowedToClose)
        {
            Exit();
            stateMachine.TransitionTo(closingState);
        }
    }

    public void Exit()
    {
        var statableThing = this.statableThing;
        statableThing.Handle.Touchable.SimpleInteractable.hoverEntered.RemoveAllListeners();
        statableThing.Openable.IsAllowedToClose = false;
    }

    private void CloseDoor() => statableThing.Openable.IsAllowedToClose = true;
}