using UnityEngine.Events;

public interface INotifierStruct<TStruct> where TStruct : struct
{
    public abstract event UnityAction<TStruct> OnChangeValue;

    public abstract void Change(TStruct _struct);
}