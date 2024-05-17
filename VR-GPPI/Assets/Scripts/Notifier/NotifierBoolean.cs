using UnityEngine;
using UnityEngine.Events;

public abstract class NotifierBoolean : MonoBehaviour, INotifierStruct<bool>
{
    public event UnityAction<bool> OnChangeValue;

    public void Change(bool isTriggered) => OnChangeValue.Invoke(isTriggered);
}