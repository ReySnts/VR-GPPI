public class ButtonDialogueBack : ButtonDialogue
{
    protected override bool DisactivateCondition => dialogueFactory.CurrentIndex <= 0;

    protected override int AddIndex => -1;
}