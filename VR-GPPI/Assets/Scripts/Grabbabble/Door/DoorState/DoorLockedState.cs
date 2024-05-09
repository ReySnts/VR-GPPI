using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorLockedState : DoorState, IStateEnterable
{
    [SerializeField] private InteractionLayerMask nothing;

    [SerializeField] private DoorUnlockingState unlockingState;

    public void Enter()
    {
        door.Rigidbody.isKinematic = true;
        door.InteractionLayerMask = nothing;
        door.GrabInteractable.interactionLayers = nothing;
    }

    public void DoUpdate()
    {
        if (door.IsLocked && door.IsTriggered) stateMachine.TransitionTo(unlockingState);
    }
}