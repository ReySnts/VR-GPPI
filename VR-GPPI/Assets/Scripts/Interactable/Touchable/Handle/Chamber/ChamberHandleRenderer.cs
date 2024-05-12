using UnityEngine;

public class ChamberHandleRenderer : MonoBehaviour, IRenderer
{
    [field: SerializeField] public MeshRenderer MeshRenderer { get; set; }

    [field: SerializeField] public Material Material { get; set; }

    private ITouchable touchable;

    private void Awake()
    {
        touchable = transform.parent.GetComponent<ITouchable>();
        touchable.SimpleInteractable.hoverEntered.AddListener(call => Change(Material));
    }

    private void Change(Material material) => MeshRenderer.material = material;

    private void OnDestroy()
    {
        touchable.SimpleInteractable.hoverEntered.RemoveListener(call => Change(Material));
        touchable = null;
    }
}