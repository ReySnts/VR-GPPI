using UnityEngine;

public class CanvasTransformer : MonoBehaviour
{
    protected Transform mainCameraTransform;

    protected virtual void Awake()
    {
        var scene = GetComponentInParent<IScene>();
        mainCameraTransform = scene.GameObject.GetComponentInChildren<Camera>().transform;
    }
}