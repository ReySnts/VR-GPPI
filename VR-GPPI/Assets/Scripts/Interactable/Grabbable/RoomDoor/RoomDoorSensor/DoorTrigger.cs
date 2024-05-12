using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private ISensorDoor sensorDoor;

    private INotifierStruct<bool> notifier;

    private void Awake()
    {
        var door = transform.parent;
        sensorDoor = door.GetComponent<ISensorDoor>();
        notifier = door.parent.parent.GetComponent<INotifierStruct<bool>>();
        notifier.OnChangeValue += Trigger;
    }

    private void Trigger(bool isTriggered) => sensorDoor.IsTriggered = isTriggered;

    private void OnDestroy()
    {
        notifier.OnChangeValue -= Trigger;
        notifier = null;
        sensorDoor = null;
    }
}