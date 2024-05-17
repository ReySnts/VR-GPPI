using UnityEngine.UI;

public interface IMenuState : IGameObject, IImageSpriteThing
{
    public abstract Button Button { get; set; }

    public abstract EMenuState EMenuState { get; }

    public abstract IMenuStateMachine MenuStateMachine { get; }
}