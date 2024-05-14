using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChamberDoorUnlockedState : DoorState<IAnimatedDoor>, IStateComplete
{
    [SerializeField] private InteractionLayerMask touchable;

    [SerializeField] private Material glow;

    [SerializeField] private ChamberDoorOpeningState openingState;

    public void Enter()
    {
        door.Lockable.IsLocked = false;
        OnEnterDoorHandle();
    }

    public void DoUpdate()
    {
        if (!door.Lockable.IsLocked && door.Openable.IsAllowedToOpen)
        {
            Exit();
            stateMachine.TransitionTo(openingState);
        }
    }

    public void Exit()
    {
        var door = this.door;
        door.Handle.Touchable.SimpleInteractable.hoverEntered.RemoveAllListeners();
        door.Openable.IsAllowedToOpen = false;
    }

    private void OnEnterDoorHandle()
    {
        var doorHandle = door.Handle;
        var doorHandleTouchable = doorHandle.Touchable;
        var doorHandleRenderer = doorHandle.Renderer;
        var doorHandleSimpleInteractable = doorHandleTouchable.SimpleInteractable;
        doorHandleTouchable.InteractionLayerMask = touchable;
        doorHandleRenderer.Material = glow;
        doorHandleRenderer.MeshRenderer.material = glow;
        doorHandleSimpleInteractable.interactionLayers = touchable;
        doorHandleSimpleInteractable.hoverEntered.AddListener(call => OpenDoor());
    }

    private void OpenDoor() => door.Openable.IsAllowedToOpen = true;
}