public interface IStateMachine<TState>
{
    public abstract void TransitionTo(TState nextState);
}