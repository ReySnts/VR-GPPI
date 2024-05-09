using UnityEngine;
using UnityEngine.Events;

public class SensorNotifier : MonoBehaviour, INotifier<Material>
{
    public event UnityAction<Material> OnChangeObject;

    public void Change(Material material) => OnChangeObject.Invoke(material);
}