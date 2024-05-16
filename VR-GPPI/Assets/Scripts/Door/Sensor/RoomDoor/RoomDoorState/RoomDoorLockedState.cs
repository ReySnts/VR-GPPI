using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RoomDoorLockedState : State<ISensorDoor, IState>, IStateEnterable
{
    [SerializeField] private InteractionLayerMask nothing;

    [SerializeField] private RoomDoorUnlockedState unlockedState;

    public void Enter()
    {
        var doorGrabbable = statableThing.Grabbable;
        doorGrabbable.Rigidbody.isKinematic = true;
        doorGrabbable.InteractionLayerMask = nothing;
        doorGrabbable.GrabInteractable.interactionLayers = nothing;
    }

    public void DoUpdate()
    {
        var statableThing = this.statableThing;
        if (statableThing.Lockable.IsLocked && statableThing.Triggerable.IsTriggered)
        {
            unlockedState.Enter();
            stateMachine.TransitionTo(unlockedState);
        }
        else Enter();
    }
}