public class ButtonLoginCancel : ButtonLogin
{
    public override void OnClick()
    {
        menuLogin.GetComponentInChildren<IButton>().Button.interactable = true;
        base.OnClick();
    }
}