using UnityEngine;

public class ButtonMainOperations : ButtonScript
{
    [SerializeField] private EMenuState menuState;

    private IStateMachine<EMenuState> stateMachine;

    protected override void Awake()
    {
        stateMachine = transform.parent.parent.parent.parent.GetComponentInChildren<IStateMachine<EMenuState>>();
        base.Awake();
    }

    public override void OnClick() => stateMachine.TransitionTo(menuState);
}