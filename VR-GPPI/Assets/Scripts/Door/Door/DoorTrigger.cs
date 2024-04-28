using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private IGrabbableLock grabLockable;

    private INotifierStruct<bool> notifier;

    private void Awake()
    {
        var door = transform.parent;
        grabLockable = door.GetComponent<IGrabbableLock>();
        notifier = door.parent.parent.GetComponent<INotifierStruct<bool>>();
        notifier.OnChangeValue += Trigger;
    }

    private void Trigger(bool isTriggered) => grabLockable.IsTriggered = isTriggered;

    private void OnDestroy()
    {
        notifier.OnChangeValue -= Trigger;
        notifier = null;
        grabLockable = null;
    }
}