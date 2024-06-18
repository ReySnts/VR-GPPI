public class KeyboardKeyEnter : ButtonScript
{
    private IKeyboard keyboard;

    protected override void Awake()
    {
        keyboard = GetComponentInParent<IKeyboard>();
        base.Awake();
    }

    public override void OnClick() => keyboard.Deactivate();
}