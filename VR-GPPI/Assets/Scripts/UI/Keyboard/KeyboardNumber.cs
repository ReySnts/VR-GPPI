using UnityEngine;

public class KeyboardNumber : KeyboardKeySpawner<int>
{
    [SerializeField] private GameObject shadowBackspace;

    [SerializeField] private GameObject backspace;

    protected override int[] Keys => new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

    protected override void Awake()
    {
        base.Awake();
        InstantiateBackspace();
    }

    private void InstantiateBackspace()
    {
        Instantiate(original: shadowBackspace, parent: shadowParent);
        Instantiate(original: backspace, parent: transform);
    }
}