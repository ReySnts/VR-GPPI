using UnityEngine;

public class Progress : MonoBehaviour, IProgress
{
    [SerializeField] private Dialogue dialogue;

    [field: SerializeField] public float Percentage { get; set; }

    public bool IsCompleted => Percentage >= 100f;

    private void Update() => dialogue.isCompleted = IsCompleted;
}