public abstract class ButtonDialogue : ButtonScript
{
    protected IFactory<Dialogue> factory;

    protected override void Awake()
    {
        factory = transform.parent.parent.parent.GetComponent<IFactory<Dialogue>>();
        base.Awake();
    }
}