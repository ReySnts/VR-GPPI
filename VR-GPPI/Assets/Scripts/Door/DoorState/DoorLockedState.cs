using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorLockedState : DoorState, IStateEnterable
{
    [SerializeField] private InteractionLayerMask nothing;

    public void Enter()
    {
        roomDoor.InteractionLayerMask = nothing;
        roomDoor.Rigidbody.isKinematic = true;
    }

    public void DoUpdate()
    {
        if (roomDoor.IsLocked && roomDoor.IsTriggered) stateMachine.TransitionTo(stateMachine.UnlockingState);
    }
}