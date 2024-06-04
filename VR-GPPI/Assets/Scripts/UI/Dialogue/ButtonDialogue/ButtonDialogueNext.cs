public class ButtonDialogueNext : ButtonDialogue
{
    protected override bool DisactivateCondition => dialogueFactory.CurrentIndex >= dialogueFactory.DialogueList.Count - 1;

    protected override int AddIndex => +1;
}