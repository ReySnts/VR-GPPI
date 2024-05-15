public interface IMenuStateMachine
{
    public abstract void TransitionTo(EMenuState nextState);
}