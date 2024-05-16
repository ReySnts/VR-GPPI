public class ChamberDoorStateMachine : EnterableStateMachine
{
    protected override IStateEnterable FirstState => GetComponentInChildren<ChamberDoorLockedState>();
}