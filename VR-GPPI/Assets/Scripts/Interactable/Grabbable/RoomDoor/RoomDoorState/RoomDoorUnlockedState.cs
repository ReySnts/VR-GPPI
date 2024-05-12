using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RoomDoorUnlockedState : DoorState<ISensorDoor>, IStateEnterable
{
    [SerializeField] private InteractionLayerMask grabbable;

    [SerializeField] private RoomDoorLockedState lockedState;

    public void Enter()
    {
        var doorGrabbable = door.Grabbable;
        doorGrabbable.InteractionLayerMask = grabbable;
        doorGrabbable.GrabInteractable.interactionLayers = grabbable;
        doorGrabbable.Rigidbody.isKinematic = false;
    }

    public void DoUpdate()
    {
        if (door.Lockable.IsLocked && !door.IsTriggered) stateMachine.TransitionTo(lockedState);
    }
}