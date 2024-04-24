using UnityEngine;

public class SensorLight : MonoBehaviour, IObserver<Material>
{
    [SerializeField] private MeshRenderer meshRenderer;

    public void Change(Material material) => meshRenderer.material = material;
}