public class ButtonDialogueBack : ButtonDialogue
{
    protected override bool IndexOutOfRange => dialogueFactory.CurrentIndex <= 0;

    protected override int AddIndex => -1;
}