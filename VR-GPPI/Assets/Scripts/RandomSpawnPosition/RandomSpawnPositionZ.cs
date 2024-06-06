using UnityEngine;

public class RandomSpawnPositionZ : MonoBehaviour
{
    [SerializeField] private float minRandomX;

    [SerializeField] private float maxRandomX;

    [SerializeField] private float minRandomY;

    [SerializeField] private float maxRandomY;

    [SerializeField] private float z;

    private float RandomX => Random.Range(minInclusive: minRandomX, maxInclusive: maxRandomX);

    private float RandomY => Random.Range(minInclusive: minRandomY, maxInclusive: maxRandomY);

    public Vector3 Value => new(x: RandomX, y: RandomY, z);
}