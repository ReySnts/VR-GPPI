using UnityEngine;
using UnityEngine.InputSystem;

public class MenuPresenter : MonoBehaviour
{
    [SerializeField] private MenuView menuView;

    [SerializeField] private InputActionProperty inputActionProperty;

    private void Update()
    {
        if (inputActionProperty.action.WasPressedThisFrame())
        {
            var menuGameObject = menuView.gameObject;
            menuGameObject.SetActive(!menuGameObject.activeSelf);
        }
    }
}