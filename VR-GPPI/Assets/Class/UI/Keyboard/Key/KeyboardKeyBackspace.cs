public class KeyboardKeyBackspace : ButtonScript
{
    public override void OnClick()
    {
        var currentInputField = GetComponentInParent<IKeyboard>().CurrentInputField.InputField;
        var currentCaretPosition = currentInputField.caretPosition;
        if (currentCaretPosition > 0)
        {
            var currentInputFieldText = currentInputField.text;
            currentInputField.text = currentInputFieldText.Remove(startIndex: currentCaretPosition - 1, count: 1);
            if (currentCaretPosition < currentInputFieldText.Length) currentInputField.caretPosition--;
        }
    }
}