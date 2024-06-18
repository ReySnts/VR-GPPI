using UnityEngine;

public class RandomSpawnPositionX : MonoBehaviour, IValuableVector3
{
    [SerializeField] private float x;

    [SerializeField] private float minRandomY;

    [SerializeField] private float maxRandomY;

    [SerializeField] private float minRandomZ;

    [SerializeField] private float maxRandomZ;

    private float RandomY => Random.Range(minInclusive: minRandomY, maxInclusive: maxRandomY);

    private float RandomZ => Random.Range(minInclusive: minRandomZ, maxInclusive: maxRandomZ);

    public Vector3 Value => new(x, y: RandomY, z: RandomZ);
}