using UnityEngine;

public class ButtonInteractabler : MonoBehaviour, IButtonInteractabler
{
    private IButton currentlyDisabled;

    private void Awake() => currentlyDisabled = transform.GetChild(0).GetComponent<IButton>();

    public void Interact(IButton other)
    {
        currentlyDisabled.Button.interactable = true;
        currentlyDisabled = other;
        other.Button.interactable = false;
    }
}