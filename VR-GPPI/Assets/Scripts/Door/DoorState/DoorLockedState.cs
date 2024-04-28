using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorLockedState : DoorState, IStateEnterable
{
    [SerializeField] private InteractionLayerMask nothing;

    public void Enter()
    {
        grabLockable.InteractionLayerMask = nothing;
        grabLockable.Rigidbody.isKinematic = true;
    }

    public void DoUpdate()
    {
        if (grabLockable.IsLocked && grabLockable.IsTriggered) stateMachine.TransitionTo(stateMachine.UnlockingState);
    }
}