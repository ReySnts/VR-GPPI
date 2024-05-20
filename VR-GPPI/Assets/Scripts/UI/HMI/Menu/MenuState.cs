using UnityEngine;

public abstract class MenuState : MonoBehaviour, IMenuState
{
    public GameObject GameObject => gameObject;

    public abstract EMenuState EMenuState { get; }

    public IMenuStateMachine MenuStateMachine { get; private set; }

    public IImageSprite ImageSprite { get; private set; }

    private void Awake()
    {
        MenuStateMachine = transform.parent.GetComponent<IMenuStateMachine>();
        ImageSprite = GetComponentInChildren<IImageSprite>();
    }
}