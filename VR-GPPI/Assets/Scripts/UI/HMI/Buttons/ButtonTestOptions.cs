using UnityEngine;

public class ButtonTestOptions : ButtonScript
{
    [SerializeField] private Sprite sprite;

    private IMenuState menuState;

    protected override void Awake()
    {
        menuState = transform.parent.parent.GetComponent<IMenuState>();
        base.Awake();
    }

    public override void OnClick()
    {
        var menuStateImageSprite = menuState.ImageSprite;
        menuStateImageSprite.Image.sprite = sprite;
        menuStateImageSprite.Sprite = sprite;
    }
}