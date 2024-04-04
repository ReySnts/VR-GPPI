using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorSensor : MonoBehaviour
{
    [SerializeField] private RoomDoor roomDoor;

    [SerializeField] private DoorSensorLight _light;

    [SerializeField] private XRSimpleInteractable simpleInteractable;

    private void Awake()
    {
        roomDoor.OnSensorHovered += _light.ChangeMaterialToGreen;
        roomDoor.OnSensorExited += _light.ChangeMaterialToBlue;
        simpleInteractable.hoverEntered.AddListener(args => roomDoor.HoverSensor());
        simpleInteractable.hoverExited.AddListener(args => roomDoor.ExitSensor());
    }

    private void OnDestroy()
    {
        roomDoor.OnSensorHovered -= _light.ChangeMaterialToGreen;
        roomDoor.OnSensorExited -= _light.ChangeMaterialToBlue;
        simpleInteractable.hoverEntered.RemoveListener(args => roomDoor.HoverSensor());
        simpleInteractable.hoverExited.RemoveListener(args => roomDoor.ExitSensor());
    }
}