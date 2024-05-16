using UnityEngine;
using UnityEngine.UI;

public class MenuLogin : MenuCanvas
{
    [SerializeField] private Button buttonActivate;

    protected override void Awake()
    {
        buttonActivate.onClick.AddListener(OnSuccessLogin);
        base.Awake();
    }

    private void OnSuccessLogin()
    {
        menuCanvas.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    private void OnDestroy() => buttonActivate.onClick.RemoveAllListeners();
}