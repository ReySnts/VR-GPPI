public class ButtonLoginOk : ButtonLogin
{
    public override void OnClick()
    {
        menuCanvas.DoTransition();
        base.OnClick();
    }
}