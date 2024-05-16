public class RoomDoorStateMachine : StateMachine<IState>
{
    protected override IState FirstState => GetComponentInChildren<RoomDoorLockedState>();
}