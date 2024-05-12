using UnityEngine;

public abstract class Lockable<TThing> : MonoBehaviour, ILockable where TThing : IThing
{
    [SerializeField] protected bool isLocked;

    public abstract bool IsLocked { get; protected set; }

    protected TThing lockableThing;

    protected void Awake() => lockableThing = transform.parent.GetComponent<TThing>();

    private void Update() => IsLocked = isLocked;
}