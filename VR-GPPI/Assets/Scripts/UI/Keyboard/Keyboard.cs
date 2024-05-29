using UnityEngine;

public class Keyboard : MonoBehaviour, IKeyboard
{
    public IInputField CurrentInputField { get; private set; }

    public void Activate(IInputField inputField)
    {
        if (!gameObject.activeSelf) gameObject.SetActive(true);
        CurrentInputField = inputField;
        CurrentInputField.InputField.caretBlinkRate = .85f;
    }

    public void Deactivate()
    {
        if (CurrentInputField is not null)
        {
            CurrentInputField.InputField.caretBlinkRate = 0f;
            CurrentInputField = null;
        }
        gameObject.SetActive(false);
    }

    private void Awake() => Deactivate();
}