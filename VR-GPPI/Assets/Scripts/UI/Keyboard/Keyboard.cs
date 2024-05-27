using UnityEngine;

public class Keyboard : MonoBehaviour, IKeyboard
{
    public IInputField CurrentInputField { get; set; }

    public GameObject GameObject => gameObject;

    private void Awake() => gameObject.SetActive(false);
}