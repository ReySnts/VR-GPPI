using UnityEngine;

public class ObjectPoolReleaseAllStack : ObjectPoolReleaseAll
{
    private IStack<GameObject> iStack;

    protected override void Awake()
    {
        base.Awake();
        iStack = GetComponent<IStack<GameObject>>();
    }

    protected override async void ReleaseAllFromPool()
    {
        while (iStack.Collection.Count > 0) await Release();
        iStack.Collection.Clear();
    }
}