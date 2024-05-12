using UnityEngine;

public class ChamberDoorAnimator : MonoBehaviour, IAnimator
{
    [field: SerializeField] public Animator Animator { get; set; }

    [field: SerializeField] public RuntimeAnimatorController AnimatorController { get; set; }

    private ITouchable touchable;

    private float currentTime;

    private bool isOpened = true;

    private void Awake()
    {
        touchable = transform.parent.GetComponentInChildren<ITouchable>();
        touchable.SimpleInteractable.hoverEntered.AddListener(call => PlayAnimation());
    }

    private void PlayAnimation()
    {
        isOpened = !isOpened;
        currentTime = Time.time;
        Animator.runtimeAnimatorController = AnimatorController;
        if (!isOpened) Animator.Play(AnimatorParameter.OPEN);
        else Animator.Play(AnimatorParameter.CLOSE);
    }

    private void Update()
    {
        var animDuration = 1f;
        if (Time.time > currentTime + animDuration)
        {
            isOpened = !isOpened;
        }
    }

    private void OnDestroy()
    {
        touchable.SimpleInteractable.hoverEntered.RemoveListener(call => PlayAnimation());
        touchable = null;
    }
}