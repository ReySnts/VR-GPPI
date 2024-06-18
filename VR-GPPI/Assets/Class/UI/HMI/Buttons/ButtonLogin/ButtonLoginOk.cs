public class ButtonLoginOk : ButtonLogin
{
    private IIsolatorThing isolator;

    protected override void Awake()
    {
        base.Awake();
        isolator = menuLogin.GetComponentInParent<IIsolatorThing>();
    }

    public override void OnClick()
    {
        isolator.IsTriggered = true;
        menuCanvas.DoTransition();
        base.OnClick();
    }
}