using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] private InputActionProperty activateValue;

    [SerializeField] private InputActionProperty selectValue;

    private void Update()
    {
        var gripValue = selectValue.action.ReadValue<float>();
        var triggerValue = activateValue.action.ReadValue<float>();
        animator.SetFloat(AnimatorParameter.GRIP, gripValue);
        animator.SetFloat(AnimatorParameter.TRIGGER, triggerValue);
    }
}