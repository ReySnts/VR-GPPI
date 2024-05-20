public interface IMenuState : IGameObject, IImageSpriteThing
{
    public abstract EMenuState EMenuState { get; }

    public abstract IMenuStateMachine MenuStateMachine { get; }
}