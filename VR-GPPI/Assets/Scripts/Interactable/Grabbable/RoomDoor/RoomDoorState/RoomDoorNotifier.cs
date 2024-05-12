using UnityEngine;
using UnityEngine.Events;

public class RoomDoorNotifier : MonoBehaviour, INotifierStruct<bool>
{
    public event UnityAction<bool> OnChangeValue;

    public void Change(bool isTriggered) => OnChangeValue.Invoke(isTriggered);
}