public class TriggerableSensorDoor : Triggerable<ISensorDoor>
{
    private INotifierStruct<bool> notifier;

    private void Awake()
    {
        notifier = transform.parent.parent.parent.parent.GetComponent<INotifierStruct<bool>>();
        notifier.OnChangeValue += Trigger;
    }

    private void Trigger(bool isTriggered) => IsTriggered = isTriggered;

    private void OnDestroy()
    {
        notifier.OnChangeValue -= Trigger;
        notifier = null;
    }
}