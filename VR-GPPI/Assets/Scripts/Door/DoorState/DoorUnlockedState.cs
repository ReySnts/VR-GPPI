public class DoorUnlockedState : DoorState
{
    public override void Enter()
    {
        stateMachine.IsLocked = false;
        //grabInteractable.interactionLayers = interactionLayerMask;
    }

    public override void Update()
    {
        //if (door.rotation.z == initialPosition) stateMachine.TransitionTo(stateMachine.LockedState);
    }

    public override void Exit()
    {
        stateMachine.IsLocked = true;
    }
}