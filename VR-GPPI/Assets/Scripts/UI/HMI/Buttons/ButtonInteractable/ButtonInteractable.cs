public class ButtonInteractable : ButtonScript
{
    private IButtonInteractabler interactabler;

    protected override void Awake()
    {
        interactabler = GetComponentInParent<IButtonInteractabler>();
        base.Awake();
    }

    public override void OnClick() => interactabler.Interact(this);
}