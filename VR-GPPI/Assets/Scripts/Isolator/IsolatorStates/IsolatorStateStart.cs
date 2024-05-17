using UnityEngine;

public class IsolatorStateStart : IsolatorEnterableState, IStateEnterable
{
    [SerializeField] private IsolatorStateLogin loginState;

    private float currentTime;

    public void Enter() => currentTime = Time.time;

    public void DoUpdate()
    {
        var startDuration = 10f;
        if (Time.time > currentTime + startDuration) stateMachine.TransitionTo(loginState);
    }
}