using UnityEngine;

public class ChamberDoorOpeningState : State<IAnimatedDoor, IStateEnterable>, IStateEnterable
{
    [SerializeField] private Material silver;

    [SerializeField] private ChamberDoorOpenedState openedState;

    private float currentTime;

    public void Enter()
    {
        OnEnterDoorAnimator();
        OnEnterDoorHandle();
    }

    public void DoUpdate()
    {
        var animationDuration = 1f;
        if (Time.time > currentTime + animationDuration) stateMachine.TransitionTo(openedState);
    }

    private void OnEnterDoorAnimator()
    {
        currentTime = Time.time;
        statableThing.Notifier.Change(AnimatorParameter.OPEN);
    }

    private void OnEnterDoorHandle()
    {
        var doorHandle = statableThing.Handle;
        var doorHandleRenderer = doorHandle.Renderer;
        doorHandleRenderer.Material = silver;
        doorHandleRenderer.MeshRenderer.material = silver;
    }
}