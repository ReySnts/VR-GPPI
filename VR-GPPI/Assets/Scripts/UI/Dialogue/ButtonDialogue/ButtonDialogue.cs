public abstract class ButtonDialogue : ButtonScript
{
    protected abstract bool IndexOutOfRange {  get; }

    protected abstract int AddIndex { get; }

    protected IDialogueFactory dialogueFactory;

    protected override void Awake()
    {
        dialogueFactory = GetComponentInParent<IDialogueFactory>();
        if (IndexOutOfRange) Destroy(gameObject);
        else base.Awake();
    }

    public override void OnClick()
    {
        dialogueFactory.GetProduct(parameter: AddIndex);
        Destroy(transform.parent.parent.gameObject);
    }
}