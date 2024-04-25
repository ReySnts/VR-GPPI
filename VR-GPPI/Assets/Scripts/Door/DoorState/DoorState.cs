using UnityEngine;

public abstract class DoorState : MonoBehaviour, IState
{
    //[SerializeField] protected InteractionLayerMask interactionLayerMask;

    //protected Transform door;

    //protected Animator animator;

    //protected Rigidbody _rigidbody;

    //protected XRGrabInteractable grabInteractable;

    protected DoorStateMachine stateMachine;

    //protected float initialPosition;

    public abstract void Enter();

    public abstract void Update();

    public abstract void Exit();

    protected void Awake()
    {
        //door = transform.parent.parent.transform;
        //initialPosition = door.position.z;
        //animator = door.GetComponent<Animator>();
        //_rigidbody = door.GetComponent<Rigidbody>();
        //grabInteractable = door.GetComponent<XRGrabInteractable>();
        //stateMachine = transform.parent.GetComponent<DoorStateMachine>();
    }
}