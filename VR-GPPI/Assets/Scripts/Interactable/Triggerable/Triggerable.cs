using UnityEngine;

public abstract class Triggerable<TThing> : MonoBehaviour, ITriggerable where TThing : IThing
{
    [field: SerializeField] public bool IsTriggered { get; protected set; }

    protected TThing triggerableThing;

    private void Awake() => triggerableThing = GetComponentInParent<TThing>();
}