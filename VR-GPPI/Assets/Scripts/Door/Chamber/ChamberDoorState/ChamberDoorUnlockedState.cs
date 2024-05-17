using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChamberDoorUnlockedState : AnimatedDoorEnterableState, IStateComplete
{
    [SerializeField] private InteractionLayerMask touchable;

    [SerializeField] private Material glow;

    [SerializeField] private ChamberDoorOpeningState openingState;

    public void Enter()
    {
        statableThing.Lockable.IsLocked = false;
        OnEnterDoorHandle();
    }

    public void DoUpdate()
    {
        var statableThing = this.statableThing;
        if (!statableThing.Lockable.IsLocked && statableThing.Openable.IsAllowedToOpen)
        {
            Exit();
            stateMachine.TransitionTo(openingState);
        }
    }

    public void Exit()
    {
        var statableThing = this.statableThing;
        statableThing.Handle.Touchable.SimpleInteractable.hoverEntered.RemoveAllListeners();
        statableThing.Openable.IsAllowedToOpen = false;
    }

    private void OnEnterDoorHandle()
    {
        var doorHandle = statableThing.Handle;
        var doorHandleTouchable = doorHandle.Touchable;
        var doorHandleRenderer = doorHandle.Renderer;
        var doorHandleSimpleInteractable = doorHandleTouchable.SimpleInteractable;
        doorHandleTouchable.InteractionLayerMask = touchable;
        doorHandleRenderer.Material = glow;
        doorHandleRenderer.MeshRenderer.material = glow;
        doorHandleSimpleInteractable.interactionLayers = touchable;
        doorHandleSimpleInteractable.hoverEntered.AddListener(call => OpenDoor());
    }

    private void OpenDoor() => statableThing.Openable.IsAllowedToOpen = true;
}