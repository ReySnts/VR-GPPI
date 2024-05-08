using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctionKeys : MonoBehaviour
{
    protected Button button;

    private void Awake() => button = GetComponent<Button>();
}