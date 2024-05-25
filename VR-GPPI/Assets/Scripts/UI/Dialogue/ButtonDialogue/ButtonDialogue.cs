public abstract class ButtonDialogue : ButtonScript
{
    protected IDialogueFactory dialogueFactory;

    protected override void Awake()
    {
        dialogueFactory = transform.parent.parent.parent.GetComponent<IDialogueFactory>();
        base.Awake();
    }
}