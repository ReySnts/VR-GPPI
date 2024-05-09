public interface IStateMachine
{
    public abstract IState FirstState { get; }

    public abstract IState CurrentState { get; set; }

    public abstract void TransitionTo(IState nextState);
}