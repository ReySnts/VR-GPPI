using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChamberDoorLockedState : DoorState<IAnimatedDoor>, IStateEnterable
{
    [SerializeField] private InteractionLayerMask nothing;

    [SerializeField] private Material silver;

    [SerializeField] private ChamberDoorUnlockedState unlockedState;

    public void Enter()
    {
        var doorHandle = door.Handle;
        var doorHandleTouchable = doorHandle.Touchable;
        var doorHandleRenderer = doorHandle.Renderer;
        doorHandleTouchable.InteractionLayerMask = nothing;
        doorHandleTouchable.SimpleInteractable.interactionLayers = nothing;
        doorHandleRenderer.Material = silver;
        doorHandleRenderer.MeshRenderer.material = silver;
    }

    public void DoUpdate()
    {
        var doorOpenable = door.Openable;
        if (!door.Lockable.IsLocked && !doorOpenable.IsAllowedToOpen && !doorOpenable.IsAllowedToClose) stateMachine.TransitionTo(unlockedState);
    }
}