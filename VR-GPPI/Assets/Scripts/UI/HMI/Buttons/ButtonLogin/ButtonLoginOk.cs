using UnityEngine;

public class ButtonLoginOk : ButtonLogin
{
    [SerializeField] private HMIMenu hMIMenu;

    [SerializeField] private GameObject buttonShutdown;

    [SerializeField] private Sprite halamanUtama;

    public override void DisablePopup()
    {
        buttonShutdown.SetActive(true);
        hMIMenu.Set(halamanUtama);
        base.DisablePopup();
    }
}