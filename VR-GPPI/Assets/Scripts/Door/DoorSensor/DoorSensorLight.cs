using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorSensorLight : MonoBehaviour
{
    [SerializeField] private XRSimpleInteractable simpleInteractable;

    [SerializeField] private SensorNotifier hoverSensorNotifier;

    [SerializeField] private SensorNotifier exitSensorNotifier;

    [SerializeField] private MeshRenderer meshRenderer;

    private void Awake()
    {
        hoverSensorNotifier.OnAllSensorsNotified += ChangeMaterialTo;
        exitSensorNotifier.OnAllSensorsNotified += ChangeMaterialTo;
        simpleInteractable.hoverEntered.AddListener(args => hoverSensorNotifier.NotifyAllSensors());
        simpleInteractable.hoverExited.AddListener(args => exitSensorNotifier.NotifyAllSensors());
    }

    private void ChangeMaterialTo(Material material) => meshRenderer.material = material;

    private void OnDestroy()
    {
        simpleInteractable.hoverEntered.RemoveListener(args => hoverSensorNotifier.NotifyAllSensors());
        simpleInteractable.hoverExited.RemoveListener(args => exitSensorNotifier.NotifyAllSensors());
        hoverSensorNotifier.OnAllSensorsNotified -= ChangeMaterialTo;
        exitSensorNotifier.OnAllSensorsNotified -= ChangeMaterialTo;
    }
}