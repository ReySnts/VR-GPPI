public class MenuCanvasLogin : MenuCanvas, IMenuCanvas
{
    public IPanel Panel { get; private set; }

    protected override void Awake()
    {
        Panel = GetComponentInChildren<IPanel>();
        Panel.GameObject.SetActive(false);
        base.Awake();
    }
}