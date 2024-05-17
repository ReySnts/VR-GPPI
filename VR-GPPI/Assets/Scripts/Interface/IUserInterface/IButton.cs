using UnityEngine.UI;

public interface IButton : IUserInterface
{
    public abstract Button Button { get; }

    public abstract void OnClick();
}