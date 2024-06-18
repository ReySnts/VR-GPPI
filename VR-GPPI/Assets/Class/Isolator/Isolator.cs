using UnityEngine;

public class Isolator : MonoBehaviour, IIsolatorThing
{
    [field: SerializeField] public bool IsTriggered { get; set; }
}