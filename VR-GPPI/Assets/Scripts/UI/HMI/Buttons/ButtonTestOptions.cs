using UnityEngine;

public class ButtonTestOptions : ButtonInteractable
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
        base.OnClick();
    }
}