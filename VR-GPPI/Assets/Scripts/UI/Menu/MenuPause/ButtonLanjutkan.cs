using UnityEngine;

public class ButtonLanjutkan : ButtonScript
{
    private GameObject canvasPauseMenu;

    protected override void Awake()
    {
        canvasPauseMenu = transform.parent.parent.gameObject;
        base.Awake();
    }

    public override void OnClick() => canvasPauseMenu.SetActive(!canvasPauseMenu.activeSelf);
}