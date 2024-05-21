public class TriggerableSensorDoor : Triggerable<ISensorDoor>
{
    private INotifier<bool> notifier;

    private void Awake()
    {
        notifier = transform.parent.parent.parent.parent.GetComponent<INotifier<bool>>();
        notifier.OnAllChanged += Trigger;
    }

    private void Trigger(bool isTriggered) => IsTriggered = isTriggered;

    private void OnDestroy()
    {
        notifier.OnAllChanged -= Trigger;
        notifier = null;
    }
}