using UnityEngine;

public class Progress : MonoBehaviour, IProgress
{
    [field: SerializeField] public float Percentage { get; set; }

    public bool IsCompleted => Percentage >= 100f;
}