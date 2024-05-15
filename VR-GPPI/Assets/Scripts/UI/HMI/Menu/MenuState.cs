using UnityEngine;

public abstract class MenuState : MonoBehaviour, IMenuState
{
    public abstract EMenuState EMenuState { get; }

    public GameObject GameObject => gameObject;

    public IMenuStateMachine MenuStateMachine { get; private set; }

    protected virtual void Awake() => MenuStateMachine = transform.parent.GetComponent<IMenuStateMachine>();
}