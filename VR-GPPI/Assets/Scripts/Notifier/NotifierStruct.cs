using UnityEngine;
using UnityEngine.Events;

public abstract class NotifierStruct<TStruct> : MonoBehaviour, INotifierStruct<TStruct> where TStruct : struct
{
    public event UnityAction<TStruct> OnChangeValue;

    public void Change(TStruct _struct) => OnChangeValue.Invoke(_struct);
}