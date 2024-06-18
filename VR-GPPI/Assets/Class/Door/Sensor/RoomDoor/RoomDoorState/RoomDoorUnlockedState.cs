using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RoomDoorUnlockedState : SensorDoorState, IStateEnterable
{
    [SerializeField] private InteractionLayerMask grabbable;

    [SerializeField] private RoomDoorLockedState lockedState;

    [SerializeField] private RoomDoorOpeningState openingState;

    private float currentTime;

    public void Enter()
    {
        var doorGrabbable = statableThing.Grabbable;
        doorGrabbable.InteractionLayerMask = grabbable;
        doorGrabbable.GrabInteractable.interactionLayers = grabbable;
        doorGrabbable.Rigidbody.isKinematic = false;
        currentTime = Time.time;
    }

    public void DoUpdate()
    {
        var waitDuration = 10f;
        var doorIsTight = statableThing.Lockable.IsLocked;
        if (Time.time > currentTime + waitDuration && doorIsTight)
        {
            lockedState.Enter();
            stateMachine.TransitionTo(lockedState);
        }
        else if (!doorIsTight)
        {
            Enter();
            stateMachine.TransitionTo(openingState);
        }
    }
}