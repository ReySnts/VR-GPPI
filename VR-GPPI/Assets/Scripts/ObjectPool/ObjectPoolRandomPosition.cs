using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolRandomPosition : MonoBehaviour, IObjectPool
{
    [field: SerializeField] public int InitialSize { get; private set; }

    [SerializeField] private GameObject prefab;

    private readonly List<GameObject> list = new();

    private void Awake()
    {
        var randomSpawnPosition = GetComponent<IValuableVector3>();
        for (int i = 0; i < InitialSize; i++)
        {
            var position = transform.TransformPoint(randomSpawnPosition.Value);
            var instance = Instantiate(original: prefab, position, rotation: Quaternion.identity, parent: transform);
            Return(instance);
        }
    }

    public void Return(GameObject gameObject)
    {
        gameObject.SetActive(false);
        list.Add(gameObject);
    }

    public void Release(GameObject gameObject)
    {
        if (list.Count > 0)
        {
            gameObject.SetActive(true);
            list.Remove(gameObject);
        }
    }
}