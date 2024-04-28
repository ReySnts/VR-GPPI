using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorUnlockedState : DoorState, IStateEnterable
{
    [SerializeField] private InteractionLayerMask grabbable;

    public void Enter()
    {
        grabLockable.InteractionLayerMask = grabbable;
        grabLockable.Rigidbody.isKinematic = false;
    }

    public void DoUpdate()
    {
        if (grabLockable.IsLocked && !grabLockable.IsTriggered) stateMachine.TransitionTo(stateMachine.LockedState);
    }
}