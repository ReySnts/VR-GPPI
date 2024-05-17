using UnityEngine;

public class RoomDoorOpeningState : SensorDoorState, IState
{
    [SerializeField] private RoomDoorLockedState lockedState;

    public void DoUpdate()
    {
        if (statableThing.Lockable.IsLocked)
        {
            lockedState.Enter();
            stateMachine.TransitionTo(lockedState);
        }
    }
}