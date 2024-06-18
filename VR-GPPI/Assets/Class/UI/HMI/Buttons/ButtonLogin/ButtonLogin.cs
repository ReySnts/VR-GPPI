using UnityEngine;

public abstract class ButtonLogin : ButtonScript
{
    protected Transform menuLogin;

    protected IMenuCanvas menuCanvas;

    protected override void Awake()
    {
        menuLogin = transform.parent.parent;
        menuCanvas = menuLogin.GetComponent<IMenuCanvas>();
        base.Awake();
    }

    public override void OnClick()
    {
        menuLogin.GetComponentInChildren<IKeyboard>()?.Deactivate();
        menuCanvas.Panel.GameObject.SetActive(false);
    }
}