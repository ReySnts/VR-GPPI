using UnityEngine;

public abstract class ButtonLogin : ButtonScript
{
    protected Transform menuLogin;

    private Transform panelLogin;

    protected override void Awake()
    {
        panelLogin = transform.parent;
        menuLogin = panelLogin.parent;
        base.Awake();
    }

    public override void OnClick() => Destroy(panelLogin.gameObject);
}