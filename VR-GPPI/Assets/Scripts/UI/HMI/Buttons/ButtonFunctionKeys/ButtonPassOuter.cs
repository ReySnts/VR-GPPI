using UnityEngine;

public class ButtonPassOuter : ButtonFunctionKeys, IAnimator
{
    [field: SerializeField] public Animator Animator { get; set; }

    [field: SerializeField] public RuntimeAnimatorController AnimatorController { get; set; }

    private bool isOpened = false;

    private void OnEnable() => button.onClick.AddListener(() => OnClick());

    private void OnClick()
    {
        Animator.runtimeAnimatorController = AnimatorController;
        if (!isOpened) Animator.Play(AnimatorParameter.OPEN);
        else Animator.Play(AnimatorParameter.CLOSE);
        isOpened = !isOpened;
    }

    private void OnDisable() => button.onClick.RemoveListener(() => OnClick());
}