using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public interface IGrabbable
{
    public abstract InteractionLayerMask InteractionLayerMask { get; }

    public abstract Rigidbody Rigidbody { get; }

    public abstract XRGrabInteractable GrabInteractable { get; }
}