using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorLockedState : DoorState, IStateEnterable
{
    [SerializeField] private InteractionLayerMask nothing;

    public void Enter()
    {
        roomDoor.Rigidbody.isKinematic = true;
        roomDoor.InteractionLayerMask = nothing;
        roomDoor.GrabInteractable.interactionLayers = nothing;
    }

    public void DoUpdate()
    {
        if (roomDoor.IsLocked && roomDoor.IsTriggered) stateMachine.TransitionTo(stateMachine.UnlockingState);
    }
}