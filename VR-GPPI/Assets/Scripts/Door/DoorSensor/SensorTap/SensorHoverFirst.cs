using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class SensorHoverFirst : SensorTap<HoverEnterEventArgs>
{
    protected override UnityEvent<HoverEnterEventArgs> InteractableEvent => simpleInteractable.firstHoverEntered;
}