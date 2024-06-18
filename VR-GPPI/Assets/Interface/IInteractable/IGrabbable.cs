using UnityEngine.XR.Interaction.Toolkit;

public interface IGrabbable : IInteractable
{
    public abstract XRGrabInteractable GrabInteractable { get; }
}