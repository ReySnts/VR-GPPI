using UnityEngine;

public class IsolatorStateLogin : State<IThing, IStateEnterable>, IStateEnterable
{
    [SerializeField] private MenuCanvas menuLogin;

    public void Enter() => menuLogin.gameObject.SetActive(true);

    public void DoUpdate()
    {

    }
}