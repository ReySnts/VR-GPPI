using UnityEngine;

public class ChamberDoorOpenedState : DoorState<IAnimatedDoor>, IStateComplete
{
    [SerializeField] private ChamberDoorClosingState closingState;

    public void Enter() => door.Handle.Touchable.SimpleInteractable.hoverEntered.AddListener(call => CloseDoor());

    public void DoUpdate()
    {
        var doorOpenable = door.Openable;
        if (!doorOpenable.IsAllowedToOpen && doorOpenable.IsAllowedToClose)
        {
            Exit();
            stateMachine.TransitionTo(closingState);
        }
    }

    public void Exit()
    {
        var door = this.door;
        door.Handle.Touchable.SimpleInteractable.hoverEntered.RemoveAllListeners();
        door.Openable.IsAllowedToClose = false;
    }

    private void CloseDoor() => door.Openable.IsAllowedToClose = true;
}