public class ButtonActivate : ButtonScript
{
    private IMenuCanvas menuCanvas;

    protected override void Awake()
    {
        menuCanvas = transform.parent.GetComponent<IMenuCanvas>();
        base.Awake();
    }

    public override void OnClick()
    {
        Button.interactable = false;
        menuCanvas.Panel.GameObject.SetActive(true);
    }
}