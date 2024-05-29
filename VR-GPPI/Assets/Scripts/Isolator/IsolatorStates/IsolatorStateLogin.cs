using UnityEngine;

public class IsolatorStateLogin : IsolatorEnterableState, IStateComplete
{
    [SerializeField] private MenuCanvas menuLogin;

    [SerializeField] private IsolatorStatePreoperational preoperationalState;

    public void Enter() => menuLogin.gameObject.SetActive(true);

    public void DoUpdate()
    {
        if (statableThing.IsTriggered)
        {
            Exit();
            stateMachine.TransitionTo(preoperationalState);
        }
    }

    public void Exit() => statableThing.IsTriggered = false;
}