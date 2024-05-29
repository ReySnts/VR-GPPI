public class KeyboardKeyEnter : ButtonScript
{
    private IKeyboard keyboard;

    protected override void Awake()
    {
        keyboard = transform.parent.parent.parent.parent.parent.parent.parent.GetComponent<IKeyboard>();
        base.Awake();
    }

    public override void OnClick() => keyboard.Deactivate();
}