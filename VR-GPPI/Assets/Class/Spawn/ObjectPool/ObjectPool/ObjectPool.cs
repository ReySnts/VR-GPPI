using System.Collections;
using UnityEngine;

public abstract class ObjectPool<TCollection> : MonoBehaviour, IObjectPool where TCollection : ICollection
{
    [field: SerializeField] public int InitialSize { get; private set; }

    protected TCollection collection;

    private void Awake() => collection = GetComponent<ICollectionGeneric<TCollection>>().Collection;

    public virtual void ReturnToPool(GameObject gameObject) => gameObject.SetActive(false);

    public abstract void ReleaseFromPool();
}