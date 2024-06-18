using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolStack : ObjectPool<Stack<GameObject>>
{
    public override void ReturnToPool(GameObject gameObject)
    {
        base.ReturnToPool(gameObject);
        collection.Push(gameObject);
    }

    public override void ReleaseFromPool()
    {
        var instance = collection.Pop();
        instance.SetActive(true);
    }
}