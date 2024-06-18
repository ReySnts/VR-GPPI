using UnityEngine.XR.Interaction.Toolkit;

public interface ITouchable : IInteractable
{
    public abstract XRSimpleInteractable SimpleInteractable { get; }
}