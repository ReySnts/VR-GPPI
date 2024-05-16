using UnityEngine;

public class RoomDoorOpeningState : State<IDoor, IState>, IState
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