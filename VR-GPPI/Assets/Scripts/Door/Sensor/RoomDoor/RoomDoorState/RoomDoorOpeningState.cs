using UnityEngine;

public class RoomDoorOpeningState : DoorState<ILockableThing>, IState
{
    [SerializeField] private RoomDoorLockedState lockedState;

    public void DoUpdate()
    {
        if (door.Lockable.IsLocked)
        {
            lockedState.Enter();
            stateMachine.TransitionTo(lockedState);
        }
    }
}