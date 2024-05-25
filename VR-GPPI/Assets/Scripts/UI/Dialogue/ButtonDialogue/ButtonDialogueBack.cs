public class ButtonDialogueBack : ButtonDialogue
{
    public override void OnClick()
    {
        if (dialogueFactory.CurrentIndex > 0)
        {
            dialogueFactory.GetProduct(parameter: -1);
            Destroy(transform.parent.parent.gameObject);
        }
    }
}