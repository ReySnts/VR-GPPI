using UnityEngine;

public class ObjectPoolRandomPosition : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    private void Awake()
    {
        var iObjectPool = GetComponent<IObjectPool>();
        var randomSpawnPosition = GetComponent<IValuableVector3>();
        for (int i = 0; i < iObjectPool.InitialSize; i++)
        {
            var position = transform.TransformPoint(randomSpawnPosition.Value);
            var instance = Instantiate(original: prefab, position, rotation: Quaternion.identity, parent: transform);
            iObjectPool.ReturnToPool(instance);
        }
    }
}