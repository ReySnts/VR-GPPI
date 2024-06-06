using UnityEngine;

public class XRLocomotionSystem : MonoBehaviour, ILocomotionSystem
{
    public IMoveProvider MoveProvider {  get; private set; }

    private void Awake() => MoveProvider = GetComponentInChildren<IMoveProvider>();
}