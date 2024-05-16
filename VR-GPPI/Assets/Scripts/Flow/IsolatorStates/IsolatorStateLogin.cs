using UnityEngine;

public class IsolatorStateLogin : State<IStateEnterable>, IStateEnterable
{
    [SerializeField] private MenuCanvas menuLogin;

    public void Enter() => menuLogin.gameObject.SetActive(true);

    public void DoUpdate()
    {

    }
}