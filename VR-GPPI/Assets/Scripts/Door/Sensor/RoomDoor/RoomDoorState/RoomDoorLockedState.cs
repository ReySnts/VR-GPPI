using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RoomDoorLockedState : DoorState<ISensorDoor>, IStateEnterable
{
    [SerializeField] private InteractionLayerMask nothing;

    [SerializeField] private RoomDoorUnlockedState unlockedState;

    public void Enter()
    {
        var doorGrabbable = door.Grabbable;
        doorGrabbable.Rigidbody.isKinematic = true;
        doorGrabbable.InteractionLayerMask = nothing;
        doorGrabbable.GrabInteractable.interactionLayers = nothing;
    }

    public void DoUpdate()
    {
        if (door.Lockable.IsLocked && door.Triggerable.IsTriggered) stateMachine.TransitionTo(unlockedState);
    }
}