using UnityEngine;
using UnityEngine.Events;

public abstract class NotifierMaterial : MonoBehaviour, INotifier<Material>
{
    public event UnityAction<Material> OnChangeObject;

    public void Change(Material material) => OnChangeObject.Invoke(material);
}