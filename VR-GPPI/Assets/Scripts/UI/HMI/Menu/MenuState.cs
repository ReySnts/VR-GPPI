using UnityEngine;
using UnityEngine.UI;

public abstract class MenuState : MonoBehaviour, IMenuState
{
    [SerializeField] protected Sprite panelSprite;

    public abstract EMenuState EMenuState { get; }

    public GameObject GameObject => gameObject;

    public IMenuStateMachine MenuStateMachine { get; private set; }

    private void Awake() => MenuStateMachine = transform.parent.GetComponent<IMenuStateMachine>();

    private void OnEnable()
    {
        var panelMenu = transform.parent.parent.GetChild(0).GetChild(0);
        var panelMenuImage = panelMenu.GetComponent<Image>();
        panelMenuImage.sprite = panelSprite;
    }
}