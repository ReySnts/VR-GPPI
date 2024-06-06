using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] private InputActionReference leftInteractionMenu;

    private INotifier<bool> iNotifier;

    private GameObject canvasPauseMenu;

    private void Awake()
    {
        iNotifier = GetComponentInParent<INotifier<bool>>();
        canvasPauseMenu = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        if (leftInteractionMenu.action.WasPressedThisFrame())
        {
            canvasPauseMenu.SetActive(value: !canvasPauseMenu.activeSelf);
            iNotifier.ChangeAll(t: canvasPauseMenu.activeSelf);
        }
    }

    private void OnDestroy()
    {
        canvasPauseMenu = null;
        iNotifier = null;
    }
}