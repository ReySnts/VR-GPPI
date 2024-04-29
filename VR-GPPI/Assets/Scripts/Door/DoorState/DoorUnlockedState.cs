using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorUnlockedState : DoorState, IStateEnterable
{
    [SerializeField] private InteractionLayerMask grabbable;

    public void Enter()
    {
        roomDoor.InteractionLayerMask = grabbable;
        roomDoor.Rigidbody.isKinematic = false;
    }

    public void DoUpdate()
    {
        if (roomDoor.IsLocked && !roomDoor.IsTriggered) stateMachine.TransitionTo(stateMachine.LockedState);
    }
}