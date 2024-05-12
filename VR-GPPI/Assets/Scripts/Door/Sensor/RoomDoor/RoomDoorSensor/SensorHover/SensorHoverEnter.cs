using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class SensorHoverEnter : SensorHover<HoverEnterEventArgs>
{
    protected override UnityEvent<HoverEnterEventArgs> InteractableEvent => simpleInteractable.hoverEntered;
}