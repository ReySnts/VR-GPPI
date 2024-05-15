public interface IMenuState : IGameObject
{
    public abstract EMenuState EMenuState { get; }

    public abstract IMenuStateMachine MenuStateMachine { get; }
}