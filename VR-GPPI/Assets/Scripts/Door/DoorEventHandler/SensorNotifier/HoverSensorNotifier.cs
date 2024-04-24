using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class HoverSensorNotifier : SensorNotifier<HoverEnterEventArgs>
{
    public override UnityEvent<HoverEnterEventArgs> InteractableEvent => simpleInteractable.hoverEntered;
}