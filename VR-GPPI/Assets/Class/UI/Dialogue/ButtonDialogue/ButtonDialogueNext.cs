public class ButtonDialogueNext : ButtonDialogue
{
    protected override bool IndexOutOfRange => dialogueFactory.CurrentIndex >= dialogueFactory.DialogueList.Count - 1;

    protected override int AddIndex => +1;
}