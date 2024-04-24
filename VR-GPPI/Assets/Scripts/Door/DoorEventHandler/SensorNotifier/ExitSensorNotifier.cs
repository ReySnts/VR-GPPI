using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class ExitSensorNotifier : SensorNotifier<HoverExitEventArgs>
{
    public override UnityEvent<HoverExitEventArgs> InteractableEvent => simpleInteractable.hoverExited;
}