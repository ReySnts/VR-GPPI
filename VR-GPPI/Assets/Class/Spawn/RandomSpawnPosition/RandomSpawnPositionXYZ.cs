using UnityEngine;

public class RandomSpawnPositionXYZ : MonoBehaviour, IValuableVector3
{
    [SerializeField] private float minRandomX;

    [SerializeField] private float maxRandomX;

    [SerializeField] private float minRandomY;

    [SerializeField] private float maxRandomY;

    [SerializeField] private float minRandomZ;

    [SerializeField] private float maxRandomZ;

    private float RandomX => Random.Range(minInclusive: minRandomX, maxInclusive: maxRandomX);

    private float RandomY => Random.Range(minInclusive: minRandomY, maxInclusive: maxRandomY);

    private float RandomZ => Random.Range(minInclusive: minRandomZ, maxInclusive: maxRandomZ);

    public Vector3 Value => new(x: RandomX, y: RandomY, z: RandomZ);
}