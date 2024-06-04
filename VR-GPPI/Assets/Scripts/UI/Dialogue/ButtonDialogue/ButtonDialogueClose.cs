public class ButtonDialogueClose : ButtonScript
{
    public override void OnClick() => transform.parent.parent.gameObject.SetActive(false);
}