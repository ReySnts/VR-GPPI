using TMPro;

public class KeyboardKeyCharacter : ButtonScript, IProduct<string>
{
    private TextMeshProUGUI textMeshPro;

    public void Initialize(string character)
    {
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        textMeshPro.text = textMeshPro.text.Insert(startIndex: 0, value: character);
    }

    public override void OnClick()
    {
        var currentInputField = GetComponentInParent<IKeyboard>().CurrentInputField.InputField;
        currentInputField.text = currentInputField.text.Insert(startIndex: currentInputField.caretPosition, value: textMeshPro.text);
        currentInputField.caretPosition++;
    }
}