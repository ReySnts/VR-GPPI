public abstract class EnterableStateMachine : StateMachine<IStateEnterable>
{
    protected override IStateEnterable FirstState { get; }

    public override void TransitionTo(IStateEnterable nextState)
    {
        base.TransitionTo(nextState);
        nextState.Enter();
    }
}