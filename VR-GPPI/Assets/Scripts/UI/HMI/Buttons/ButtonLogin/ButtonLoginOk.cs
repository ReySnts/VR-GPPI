public class ButtonLoginOk : ButtonLogin
{
    public override void OnClick()
    {
        menuLogin.GetComponent<IMenuCanvas>().DoTransition();
        base.OnClick();
    }
}