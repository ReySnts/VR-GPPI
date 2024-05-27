using TMPro;

public class KeyboardKey : ButtonScript, IProduct<string>
{
    protected TextMeshProUGUI textMeshPro;

    private IKeyboard keyboard;

    protected override void Awake()
    {
        keyboard = transform.parent.parent.parent.parent.parent.parent.parent.GetComponent<IKeyboard>();
        base.Awake();
    }

    public void Initialize(string character)
    {
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        textMeshPro.text = character;
    }

    public override void OnClick()
    {
        var currentInputField = keyboard.CurrentInputField.InputField;
        var currentInputFieldText = currentInputField.text;
        keyboard.CurrentInputField.InputField.text = string.Concat(currentInputFieldText, textMeshPro.text);
    }
}