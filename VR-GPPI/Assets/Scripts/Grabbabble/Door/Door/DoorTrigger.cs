using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private IDoor door;

    private INotifierStruct<bool> notifier;

    private void Awake()
    {
        var door = transform.parent;
        this.door = door.GetComponent<IDoor>();
        notifier = door.parent.parent.GetComponent<INotifierStruct<bool>>();
        notifier.OnChangeValue += Trigger;
    }

    private void Trigger(bool isTriggered) => door.IsTriggered = isTriggered;

    private void OnDestroy()
    {
        notifier.OnChangeValue -= Trigger;
        notifier = null;
        door = null;
    }
}