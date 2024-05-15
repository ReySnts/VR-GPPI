using UnityEngine;

public class LoginState : IsolatorState, IStateEnterable
{
    [SerializeField] private MenuCanvas menuLogin;

    public void Enter() => menuLogin.gameObject.SetActive(true);

    public void DoUpdate()
    {

    }
}