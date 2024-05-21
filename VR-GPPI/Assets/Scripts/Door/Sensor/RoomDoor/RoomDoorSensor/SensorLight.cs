using UnityEngine;

public class SensorLight : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;

    private INotifier<Material> notifier;

    private void Change(Material material) => meshRenderer.material = material;

    private void Awake()
    {
        notifier = transform.parent.parent.parent.GetComponent<INotifier<Material>>();
        notifier.OnAllChanged += Change;
    }

    private void OnDestroy()
    {
        notifier.OnAllChanged -= Change;
        notifier = null;
    }
}