using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public interface IInteractable
{
    public abstract InteractionLayerMask InteractionLayerMask { get; set; }

    public abstract Rigidbody Rigidbody { get; }
}