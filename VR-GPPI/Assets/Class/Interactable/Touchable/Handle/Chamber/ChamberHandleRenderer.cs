using UnityEngine;

public class ChamberHandleRenderer : MonoBehaviour, IRenderer
{
    [field: SerializeField] public MeshRenderer MeshRenderer { get; set; }

    [field: SerializeField] public Material Material { get; set; }
}