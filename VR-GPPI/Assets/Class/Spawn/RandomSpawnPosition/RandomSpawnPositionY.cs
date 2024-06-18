using UnityEngine;

public class RandomSpawnPositionY : MonoBehaviour, IValuableVector3
{
    [SerializeField] private float minRandomX;

    [SerializeField] private float maxRandomX;

    [SerializeField] private float y;

    [SerializeField] private float minRandomZ;

    [SerializeField] private float maxRandomZ;

    private float RandomX => Random.Range(minInclusive: minRandomX, maxInclusive: maxRandomX);

    private float RandomZ => Random.Range(minInclusive: minRandomZ, maxInclusive: maxRandomZ);

    public Vector3 Value => new(x: RandomX, y, z: RandomZ);
}