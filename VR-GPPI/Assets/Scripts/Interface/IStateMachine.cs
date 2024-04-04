public interface IStateMachine
{
    public abstract void TransitionTo(IState nextState);
}