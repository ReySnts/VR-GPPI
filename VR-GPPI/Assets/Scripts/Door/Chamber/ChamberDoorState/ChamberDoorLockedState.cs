using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChamberDoorLockedState : AnimatedDoorEnterableState, IStateEnterable
{
    [SerializeField] private InteractionLayerMask nothing;

    [SerializeField] private ChamberDoorUnlockedState unlockedState;

    public void Enter()
    {
        statableThing.Lockable.IsLocked = true;
        OnEnterDoorHandle();
    }

    public void DoUpdate()
    {
        if (!statableThing.Lockable.IsLocked) stateMachine.TransitionTo(unlockedState);
    }

    private void OnEnterDoorHandle()
    {
        var doorHandle = statableThing.Handle;
        var doorHandleTouchable = doorHandle.Touchable;
        doorHandleTouchable.InteractionLayerMask = nothing;
        doorHandleTouchable.SimpleInteractable.interactionLayers = nothing;
    }
}