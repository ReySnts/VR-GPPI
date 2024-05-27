using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonScript : MonoBehaviour, IButton
{
    public Button Button { get; private set; }

    protected virtual void Awake()
    {
        Button = GetComponent<Button>();
        Button.onClick.AddListener(OnClick);
    }

    public abstract void OnClick();

    protected virtual void OnDestroy()
    {
        Button.onClick.RemoveListener(OnClick);
        Button = null;
    }
}