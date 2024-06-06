using UnityEngine.XR.Interaction.Toolkit;

public interface IMoveProvider
{
    public abstract ActionBasedContinuousMoveProvider ActionBasedContinuous { get; }
}