using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonFunctionKeys : MonoBehaviour, IButton
{
    public Button Button { get; private set; }

    private void Awake()
    {
        Button = GetComponent<Button>();
        Button.onClick.AddListener(OnClick);
    }

    public abstract void OnClick();

    private void OnDestroy()
    {
        Button.onClick.RemoveListener(OnClick);
        Button = null;
    }
}