using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private IRoomDoor roomDoor;

    private INotifierStruct<bool> notifier;

    private void Awake()
    {
        var door = transform.parent;
        roomDoor = door.GetComponent<IRoomDoor>();
        notifier = door.parent.parent.GetComponent<INotifierStruct<bool>>();
        notifier.OnChangeValue += Trigger;
    }

    private void Trigger(bool isTriggered) => roomDoor.IsTriggered = isTriggered;

    private void OnDestroy()
    {
        notifier.OnChangeValue -= Trigger;
        notifier = null;
        roomDoor = null;
    }
}