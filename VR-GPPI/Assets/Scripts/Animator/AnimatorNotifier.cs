using UnityEngine;
using UnityEngine.Events;

public class AnimatorNotifier : MonoBehaviour, INotifier<string>
{
    public event UnityAction<string> OnChangeObject;

    public void Change(string animatorParameter) => OnChangeObject.Invoke(animatorParameter);
}