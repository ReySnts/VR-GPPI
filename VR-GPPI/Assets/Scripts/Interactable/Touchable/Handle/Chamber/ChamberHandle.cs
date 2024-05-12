using UnityEngine;

public class ChamberHandle : MonoBehaviour, IHandle
{
    public ITouchable Touchable { get; private set; }

    public IRenderer Renderer { get; private set; }

    private void Awake()
    {
        Touchable = GetComponentInChildren<ITouchable>();
        Renderer = GetComponentInChildren<IRenderer>();
    }
}