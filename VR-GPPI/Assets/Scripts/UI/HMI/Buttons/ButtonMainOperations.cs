using UnityEngine;

public class ButtonMainOperations : ButtonScript
{
    [SerializeField] private EMenuState menuState;

    private IMenuStateMachine menuStateMachine;

    protected override void Awake()
    {
        menuStateMachine = transform.parent.parent.parent.parent.GetComponentInChildren<IMenuStateMachine>();
        base.Awake();
    }

    public override void OnClick() => menuStateMachine.TransitionTo(menuState);
}