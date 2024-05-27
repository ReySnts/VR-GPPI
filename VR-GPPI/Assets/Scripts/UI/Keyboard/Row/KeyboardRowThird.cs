using UnityEngine;

public class KeyboardRowThird : KeyboardRow<char>
{
    [SerializeField] private Transform shadowParent;

    [SerializeField] private GameObject shadowShift;

    [SerializeField] private GameObject shadowEmpty;

    [SerializeField] private GameObject shift;

    [SerializeField] private GameObject empty;

    protected override char[] Characters => new char[] { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

    protected override void Awake()
    {
        InstantiateShift();
        InstantiateEmpty();
        base.Awake();
        InstantiateEmpty();
        InstantiateShift();
    }

    private void InstantiateShift()
    {
        Instantiate(original: shadowShift, parent: shadowParent);
        Instantiate(original: shift, parent: transform);
    }

    private void InstantiateEmpty()
    {
        Instantiate(original: shadowEmpty, parent: shadowParent);
        Instantiate(original: empty, parent: transform);
    }
}