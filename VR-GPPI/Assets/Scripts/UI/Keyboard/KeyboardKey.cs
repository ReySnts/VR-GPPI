using TMPro;
using UnityEngine;

public class KeyboardKey : MonoBehaviour, IKeyboardKey
{
    [field: SerializeField] public char Character { get; set; }

    private TextMeshProUGUI textMeshPro;

    private void Awake()
    {
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        textMeshPro.text += Character;
    }

    private void OnDestroy()
    {
        textMeshPro.text = null;
        textMeshPro = null;
    }
}