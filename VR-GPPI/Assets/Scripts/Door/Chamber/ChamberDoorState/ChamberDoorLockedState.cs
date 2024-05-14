using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChamberDoorLockedState : DoorState<IAnimatedDoor>, IStateEnterable
{
    [SerializeField] private InteractionLayerMask nothing;

    [SerializeField] private ChamberDoorUnlockedState unlockedState;

    public void Enter()
    {
        door.Lockable.IsLocked = true;
        OnEnterDoorHandle();
    }

    public void DoUpdate()
    {
        if (!door.Lockable.IsLocked) stateMachine.TransitionTo(unlockedState);
    }

    private void OnEnterDoorHandle()
    {
        var doorHandle = door.Handle;
        var doorHandleTouchable = doorHandle.Touchable;
        doorHandleTouchable.InteractionLayerMask = nothing;
        doorHandleTouchable.SimpleInteractable.interactionLayers = nothing;
    }
}