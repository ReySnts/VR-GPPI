using System;
using UnityEngine;

public class SensorNotifier : MonoBehaviour
{
    [SerializeField] protected Material lightColorMaterial;

    public event Action<Material> OnAllSensorsNotified;

    public void NotifyAllSensors() => OnAllSensorsNotified.Invoke(lightColorMaterial);
}