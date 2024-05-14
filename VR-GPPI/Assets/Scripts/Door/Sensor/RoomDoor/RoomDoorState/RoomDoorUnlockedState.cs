using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RoomDoorUnlockedState : DoorState<ISensorDoor>, IStateEnterable
{
    [SerializeField] private InteractionLayerMask grabbable;

    [SerializeField] private RoomDoorLockedState lockedState;

    private float currentTime;

    public void Enter()
    {
        var doorGrabbable = door.Grabbable;
        doorGrabbable.InteractionLayerMask = grabbable;
        doorGrabbable.GrabInteractable.interactionLayers = grabbable;
        doorGrabbable.Rigidbody.isKinematic = false;
        currentTime = Time.time;
    }

    public void DoUpdate()
    {
        var waitDuration = 10f;
        if (Time.time > currentTime + waitDuration && door.Lockable.IsLocked) stateMachine.TransitionTo(lockedState);
    }
}