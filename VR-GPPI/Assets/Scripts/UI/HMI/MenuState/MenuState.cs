using UnityEngine;
using UnityEngine.UI;

public abstract class MenuState : MonoBehaviour, IMenuState
{
    [SerializeField] protected Sprite panelSprite;

    protected MenuStateMachine stateMachine;

    public abstract EMenuState EMenuState { get; }

    public GameObject GameObject => gameObject;

    protected virtual void Awake() => stateMachine = transform.parent.GetComponent<MenuStateMachine>();

    private void OnEnable()
    {
        var panelMenu = transform.parent.parent.GetChild(0).GetChild(0);
        var panelMenuImage = panelMenu.GetComponent<Image>();
        panelMenuImage.sprite = panelSprite;
    }
}