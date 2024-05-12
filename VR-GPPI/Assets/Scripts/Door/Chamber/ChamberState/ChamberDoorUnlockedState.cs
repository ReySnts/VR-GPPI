using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChamberDoorUnlockedState : DoorState<IAnimatedDoor>, IStateComplete
{
    [SerializeField] private InteractionLayerMask touchable;

    [SerializeField] private Material glow;

    [SerializeField] private ChamberDoorOpeningState openingState;

    public void Enter()
    {
        var doorHandle = door.Handle;
        var doorHandleTouchable = doorHandle.Touchable;
        var doorHandleSimpleInteractable = doorHandleTouchable.SimpleInteractable;
        doorHandle.Renderer.MeshRenderer.material = glow;
        doorHandleTouchable.InteractionLayerMask = touchable;
        doorHandleSimpleInteractable.interactionLayers = touchable;
        doorHandleSimpleInteractable.hoverEntered.AddListener(call => OpenDoor());
    }

    public void DoUpdate()
    {
        var doorOpenable = door.Openable;
        if (!door.Lockable.IsLocked && doorOpenable.IsAllowedToOpen && !doorOpenable.IsAllowedToClose) stateMachine.TransitionTo(openingState);
    }

    public void Exit() => door.Handle.Touchable.SimpleInteractable.hoverEntered.RemoveListener(call => OpenDoor());

    private void OpenDoor() => door.Openable.IsAllowedToOpen = true;
}