using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectPool<T> : MonoBehaviour, IObjectPool<T> where T : IGameObject
{
    [SerializeField] protected GameObject prefab;

    [SerializeField] protected int initialSize;

    private readonly List<T> list = new();

    private void Awake()
    {
        var randomPosition = GetComponent<IValuableVector3>().Value;
        for (int i = 0; i < initialSize; i++)
        {
            var instance = Instantiate(original: prefab, position: randomPosition, rotation: Quaternion.identity, parent: transform);
            var type = instance.GetComponent<T>();
            Return(type);
        }
    }

    public void Return(T t)
    {
        t.GameObject.SetActive(false);
        list.Add(t);
    }

    public void Release(T t)
    {
        if (list.Count > 0)
        {
            t.GameObject.SetActive(true);
            list.Remove(t);
        }
    }
}