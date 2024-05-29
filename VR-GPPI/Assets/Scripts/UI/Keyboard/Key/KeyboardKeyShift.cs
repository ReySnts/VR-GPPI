public class KeyboardKeyShift : ButtonScript
{
    private INotifier<bool> notifier;

    private bool isCapitalized = false;

    protected override void Awake()
    {
        notifier = transform.parent.parent.parent.GetComponent<INotifier<bool>>();
        notifier.OnAllChanged += Capitalize;
        base.Awake();
    }

    private void Capitalize(bool isCapitalized) => this.isCapitalized = isCapitalized;

    public override void OnClick() => notifier.ChangeAll(!isCapitalized);

    protected override void OnDestroy()
    {
        notifier.OnAllChanged -= Capitalize;
        notifier = null;
        base.OnDestroy();
    }
}