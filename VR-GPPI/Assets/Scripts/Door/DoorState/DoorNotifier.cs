using UnityEngine;
using UnityEngine.Events;

public class DoorNotifier : MonoBehaviour, INotifier<IState>
{
    public event UnityAction<IState> OnChangeObject;

    public void Change(IState nextState) => OnChangeObject.Invoke(nextState);
}