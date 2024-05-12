using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class SensorHoverExit : SensorHover<HoverExitEventArgs>
{
    protected override UnityEvent<HoverExitEventArgs> InteractableEvent => simpleInteractable.hoverExited;
}