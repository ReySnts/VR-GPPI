using TMPro;

public class KeyboardKeyCharacter : ButtonScript, IProduct<string>
{
    private TMP_InputField currentInputField;

    private TextMeshProUGUI textMeshPro;

    protected override void Awake()
    {
        currentInputField = transform.parent.parent.parent.parent.parent.parent.parent.GetComponent<IKeyboard>().CurrentInputField.InputField;
        base.Awake();
    }

    public void Initialize(string character)
    {
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        textMeshPro.text = textMeshPro.text.Insert(startIndex: 0, value: character);
    }

    public override void OnClick()
    {
        currentInputField.text = currentInputField.text.Insert(startIndex: currentInputField.caretPosition, value: textMeshPro.text);
        currentInputField.caretPosition++;
    }
}