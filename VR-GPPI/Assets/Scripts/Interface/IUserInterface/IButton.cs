using UnityEngine.UI;

public interface IButton
{
    public abstract Button Button { get; }

    public abstract void OnClick();
}