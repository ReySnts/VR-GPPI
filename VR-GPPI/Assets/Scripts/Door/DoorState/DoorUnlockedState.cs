using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorUnlockedState : DoorState
{
    [SerializeField] private InteractionLayerMask grabbable;

    public override void Enter()
    {
        stateMachine.IsLocked = false;
        door.InteractionLayerMask = grabbable;
        door.Rigidbody.isKinematic = false;
    }

    public override void DoUpdate()
    {
        if (door.transform.rotation.z == door.InitialRotationZ) stateMachine.TransitionTo(stateMachine.LockedState);
    }

    public override void Exit()
    {
        stateMachine.IsLocked = true;
    }
}