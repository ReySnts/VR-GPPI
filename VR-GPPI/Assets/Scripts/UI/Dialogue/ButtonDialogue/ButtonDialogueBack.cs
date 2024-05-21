public class ButtonDialogueBack : ButtonDialogue
{
    public override void OnClick()
    {
        var currentDialogueIndex = factory.CurrentIndex;
        if (currentDialogueIndex < 1) return;
        factory.GetProduct(factory.CurrentIndex--);
        Destroy(transform.parent.parent);
    }
}