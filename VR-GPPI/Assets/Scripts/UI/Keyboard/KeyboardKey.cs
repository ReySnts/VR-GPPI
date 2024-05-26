using TMPro;
using UnityEngine;

public class KeyboardKey : MonoBehaviour, IProduct<string>
{
    public void Initialize(string character)
    {
        var textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        textMeshPro.text = character;
    }
}