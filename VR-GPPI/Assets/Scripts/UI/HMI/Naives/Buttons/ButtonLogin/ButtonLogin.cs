using UnityEngine;

public class ButtonLogin : MonoBehaviour
{
    [SerializeField] protected GameObject popupLogin;

    public virtual void DisablePopup()
    {
        popupLogin.SetActive(false);
    }
}