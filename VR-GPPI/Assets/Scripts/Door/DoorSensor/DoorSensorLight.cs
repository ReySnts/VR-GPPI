using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorSensorLight : MonoBehaviour
{
    [SerializeField] private XRSimpleInteractable simpleInteractable;

    [SerializeField] private MeshRenderer meshRenderer;

    [SerializeField] private Material blueRoomDoorSensor;

    [SerializeField] private Material greenRoomDoorSensor;

    private void Awake()
    {
        simpleInteractable.hoverEntered.AddListener(args => ChangeMaterialToGreen());
        simpleInteractable.hoverExited.AddListener(args => ChangeMaterialToBlue());
    }

    private void ChangeMaterialTo(Material material) => meshRenderer.material = material;

    public void ChangeMaterialToGreen() => ChangeMaterialTo(greenRoomDoorSensor);

    public void ChangeMaterialToBlue() => ChangeMaterialTo(blueRoomDoorSensor);

    private void OnDestroy()
    {
        simpleInteractable.hoverEntered.RemoveListener(args => ChangeMaterialToGreen());
        simpleInteractable.hoverExited.RemoveListener(args => ChangeMaterialToBlue());
    }
}