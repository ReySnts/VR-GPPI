using System;
using UnityEngine;

public class RoomDoor : MonoBehaviour
{
    public event Action OnDoorLocked;

    public event Action OnDoorUnlocked;

    public event Action OnSensorHovered;

    public event Action OnSensorExited;

    public void HoverSensor() => OnSensorHovered.Invoke();

    public void ExitSensor() => OnSensorExited.Invoke();
}