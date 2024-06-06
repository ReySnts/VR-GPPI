using Unity.XR.CoreUtils;
using UnityEngine;

public class Scene : MonoBehaviour, IScene
{
    public GameObject GameObject => gameObject;

    public XROrigin XROrigin {  get; private set; }

    private void Awake() => XROrigin = GetComponentInChildren<XROrigin>();
}