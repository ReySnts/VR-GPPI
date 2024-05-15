using UnityEngine;

public abstract class IsolatorState : MonoBehaviour
{
    protected IStateMachine stateMachine;

    protected void Awake() => stateMachine = transform.parent.GetComponent<IStateMachine>();

    protected void OnDestroy() => stateMachine = null;
}