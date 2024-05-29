using TMPro;
using UnityEngine;

public class KeyboardInputField : MonoBehaviour, IInputField
{
    private IKeyboard keyboard;

    private TMP_InputField inputField;

    public TMP_InputField InputField => inputField;

    private void Awake()
    {
        keyboard = transform.parent.GetComponentInChildren<IKeyboard>();
        inputField = GetComponent<TMP_InputField>();
        inputField.onSelect.AddListener(OnSelect);
    }

    private void OnSelect(string str) => keyboard.Activate(this);

    private void OnDestroy()
    {
        inputField.onSelect.RemoveListener(OnSelect);
        inputField = null;
    }
}