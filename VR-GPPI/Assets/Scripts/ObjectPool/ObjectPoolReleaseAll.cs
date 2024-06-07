using UnityEngine;

public class ObjectPoolReleaseAll : MonoBehaviour
{
    private IObjectPool iObjectPool;

    private IStack<GameObject> iStack;

    private void Awake()
    {
        iObjectPool = GetComponent<IObjectPool>();
        iStack = GetComponent<IStack<GameObject>>();
    }

    public void ReleaseAllFromPool()
    {
        while (iStack.Collection.Count > 0) iObjectPool.ReleaseFromPool();
        iStack.Collection.Clear();
    }
}