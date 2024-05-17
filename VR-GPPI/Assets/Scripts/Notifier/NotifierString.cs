using UnityEngine;
using UnityEngine.Events;

public abstract class NotifierString : MonoBehaviour, INotifier<string>
{
    public event UnityAction<string> OnChangeObject;

    public void Change(string animatorParameter) => OnChangeObject.Invoke(animatorParameter);
}