using TMPro;

public class KeyboardKeyBackspace : ButtonScript
{
    private TMP_InputField currentInputField;

    protected override void Awake()
    {
        currentInputField = transform.parent.parent.parent.parent.parent.parent.parent.GetComponent<IKeyboard>().CurrentInputField.InputField;
        base.Awake();
    }

    public override void OnClick()
    {
        var currentCaretPosition = currentInputField.caretPosition;
        if (currentCaretPosition > 0)
        {
            var currentInputFieldText = currentInputField.text;
            currentInputField.text = currentInputFieldText.Remove(startIndex: currentCaretPosition - 1, count: 1);
            if (currentCaretPosition < currentInputFieldText.Length) currentInputField.caretPosition--;
        }
    }
}