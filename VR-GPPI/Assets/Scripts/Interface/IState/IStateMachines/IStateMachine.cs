public interface IStateMachine<TState> where TState : IState
{
    public abstract void TransitionTo(TState nextState);
}