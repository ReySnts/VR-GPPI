using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] private InputActionReference leftInteractionMenu;

    private GameObject canvasPauseMenu;

    private void Awake() => canvasPauseMenu = GetComponentInChildren<IGameObject>().GameObject;

    private void Update()
    {
        if (leftInteractionMenu.action.WasPressedThisFrame()) canvasPauseMenu.SetActive(!canvasPauseMenu.activeSelf);
    }
}