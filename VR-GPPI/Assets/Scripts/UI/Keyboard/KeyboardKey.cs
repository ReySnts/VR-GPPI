using TMPro;
using UnityEngine;

public class KeyboardKey : MonoBehaviour, IKeyboardKey
{
    [field: SerializeField] public string Character { get; set; }

    private TextMeshProUGUI textMeshPro;

    private void Awake()
    {
        Debug.Log(Character);
        //textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        //textMeshPro.text = Character;
    }
}