using UnityEngine;

public class Openable : MonoBehaviour, IOpenable
{
    [field: SerializeField] public bool IsAllowedToOpen { get; set; }

    [field: SerializeField] public bool IsAllowedToClose { get; set; }
}