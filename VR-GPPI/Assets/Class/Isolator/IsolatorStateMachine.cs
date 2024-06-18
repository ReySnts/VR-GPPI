public class IsolatorStateMachine : EnterableStateMachine
{
    protected override IStateEnterable FirstState => GetComponentInChildren<IsolatorStateOff>();
}