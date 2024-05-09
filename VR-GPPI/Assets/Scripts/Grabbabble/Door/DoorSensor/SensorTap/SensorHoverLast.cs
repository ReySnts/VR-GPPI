using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class SensorHoverLast : SensorTap<HoverExitEventArgs>
{
    protected override UnityEvent<HoverExitEventArgs> InteractableEvent => simpleInteractable.lastHoverExited;
}