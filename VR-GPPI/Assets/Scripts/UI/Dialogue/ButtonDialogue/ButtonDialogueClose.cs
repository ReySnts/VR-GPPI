public class ButtonDialogueClose : ButtonDialogue
{
    public override void OnClick() => transform.parent.parent.gameObject.SetActive(false);
}