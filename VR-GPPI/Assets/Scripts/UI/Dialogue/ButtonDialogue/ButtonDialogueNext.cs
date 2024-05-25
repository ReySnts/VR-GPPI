public class ButtonDialogueNext : ButtonDialogue
{
    public override void OnClick()
    {
        if (dialogueFactory.CurrentIndex < dialogueFactory.DialogueList.Count - 1)
        {
            dialogueFactory.GetProduct(parameter: 1);
            Destroy(transform.parent.parent.gameObject);
        }
    }
}