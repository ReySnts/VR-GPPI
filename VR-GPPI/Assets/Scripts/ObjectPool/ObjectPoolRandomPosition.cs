using System.Threading.Tasks;
using UnityEngine;

public class ObjectPoolRandomPosition : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    private IObjectPool iObjectPool;

    private IValuableVector3 randomSpawnPosition;

    private async void Awake()
    {
        iObjectPool = GetComponent<IObjectPool>();
        randomSpawnPosition = GetComponent<IValuableVector3>();
        var initialPoolSize = iObjectPool.InitialSize;
        for (int i = 0; i < initialPoolSize; i++) await Instantiate();
    }

    private async Task Instantiate()
    {
        await Task.Delay(millisecondsDelay: 1000);
        var position = transform.TransformPoint(randomSpawnPosition.Value);
        var instance = Instantiate(original: prefab, position, rotation: Quaternion.identity, parent: transform);
        iObjectPool.ReturnToPool(instance);
    }
}