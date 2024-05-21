public class ButtonDialogueNext : ButtonDialogue
{
    public override void OnClick()
    {
        var currentDialogueIndex = factory.CurrentIndex;
        if (currentDialogueIndex > factory.TotalProducts - 2) return;
        factory.GetProduct(factory.CurrentIndex++);
        Destroy(transform.parent.parent);
    }
}