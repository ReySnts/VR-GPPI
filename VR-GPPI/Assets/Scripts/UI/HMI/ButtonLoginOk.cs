using UnityEngine;

public class ButtonLoginOk : ButtonLogin
{
    [SerializeField] private HMIMenu hMIMenu;

    [SerializeField] private Sprite halamanUtama;

    public override void DisablePopup()
    {
        hMIMenu.Set(halamanUtama);
        base.DisablePopup();
    }
}