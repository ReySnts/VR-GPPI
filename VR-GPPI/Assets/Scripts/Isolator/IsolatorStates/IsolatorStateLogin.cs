using UnityEngine;

public class IsolatorStateLogin : IsolatorEnterableState, IStateEnterable
{
    [SerializeField] private MenuCanvas menuLogin;

    public void Enter() => menuLogin.gameObject.SetActive(true);

    public void DoUpdate()
    {

    }
}