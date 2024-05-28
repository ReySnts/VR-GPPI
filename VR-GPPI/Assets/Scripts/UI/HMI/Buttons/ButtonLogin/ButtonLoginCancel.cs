public class ButtonLoginCancel : ButtonLogin
{
    public override void OnClick()
    {
        menuLogin.GetChild(0).GetComponent<IButton>().Button.interactable = true;
        base.OnClick();
    }
}