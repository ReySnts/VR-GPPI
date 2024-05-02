using UnityEngine;

public class ButtonActivate : MonoBehaviour
{
    [SerializeField] private GameObject popupLogin;

    private void Start() => gameObject.SetActive(false);

    public void ShowPopupLogin()
    {
        popupLogin.SetActive(true);
    }
}