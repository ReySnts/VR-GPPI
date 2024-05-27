using TMPro;
using UnityEngine;

public class KeyboardKeyLetterCapitalizer : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    private INotifier<bool> notifier;

    private void Awake()
    {
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        notifier = transform.parent.parent.GetComponent<INotifier<bool>>();
        notifier.OnAllChanged += Capitalize;
    }

    private void Capitalize(bool isCapitalized)
    {
        var oldChar = textMeshPro.text[0];
        var newChar = isCapitalized ? char.ToUpper(oldChar) : char.ToLower(oldChar);
        textMeshPro.text = textMeshPro.text.Replace(oldChar, newChar);
    }

    private void OnDestroy()
    {
        notifier.OnAllChanged -= Capitalize;
        notifier = null;
        textMeshPro = null;
    }
}