using UnityEngine;

public class Progress : MonoBehaviour, IProgress
{
    [SerializeField] private Dialogue dialogue;

    [field: SerializeField] public float Percentage { get; set; }

    public GameObject GameObject => gameObject;

    public int ChildCount => transform.childCount <= 0 ? 1 : transform.childCount;

    private void Update() => dialogue.isCompleted = Percentage >= 100f;
}