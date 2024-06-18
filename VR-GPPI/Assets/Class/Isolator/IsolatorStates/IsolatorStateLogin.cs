using UnityEngine;

public class IsolatorStateLogin : IsolatorEnterableState, IStateComplete
{
    [SerializeField] private MenuCanvas menuLogin;

    [SerializeField] private IsolatorStatePreoperationalPass preoperationalPassState;

    public void Enter() => menuLogin.gameObject.SetActive(true);

    public void DoUpdate()
    {
        if (statableThing.IsTriggered)
        {
            Exit();
            stateMachine.TransitionTo(preoperationalPassState);
        }
    }

    public void Exit() => statableThing.IsTriggered = false;
}