public class ButtonLoginOk : ButtonLogin
{
    private IIsolatorThing isolator;

    protected override void Awake()
    {
        isolator = transform.parent.parent.parent.parent.GetComponent<IIsolatorThing>();
        base.Awake();
    }

    public override void OnClick()
    {
        isolator.IsTriggered = true;
        menuCanvas.DoTransition();
        base.OnClick();
    }
}