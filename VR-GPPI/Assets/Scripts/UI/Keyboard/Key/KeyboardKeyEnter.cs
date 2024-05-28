using UnityEngine;

public class KeyboardKeyEnter : ButtonScript
{
    private GameObject keyboardGameObject;

    protected override void Awake()
    {
        keyboardGameObject = transform.parent.parent.parent.parent.parent.parent.parent.GetComponent<IKeyboard>().GameObject;
        base.Awake();
    }

    public override void OnClick() => keyboardGameObject.SetActive(false);
}