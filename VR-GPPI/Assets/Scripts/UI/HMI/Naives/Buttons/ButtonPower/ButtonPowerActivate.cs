using UnityEngine;

public class ButtonPowerActivate : ButtonPower
{
    [SerializeField] private GameObject popupLogin;

    public void ShowPopupLogin()
    {
        popupLogin.SetActive(true);
    }
}