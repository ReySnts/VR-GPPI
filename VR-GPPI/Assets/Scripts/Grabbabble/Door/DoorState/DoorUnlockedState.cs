using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorUnlockedState : DoorState, IStateEnterable
{
    [SerializeField] private InteractionLayerMask grabbable;

    [SerializeField] private DoorLockedState lockedState;

    public void Enter()
    {
        door.InteractionLayerMask = grabbable;
        door.GrabInteractable.interactionLayers = grabbable;
        door.Rigidbody.isKinematic = false;
    }

    public void DoUpdate()
    {
        if (door.IsLocked && !door.IsTriggered) stateMachine.TransitionTo(lockedState);
    }
}