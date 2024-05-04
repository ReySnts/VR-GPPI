using UnityEngine;
using UnityEngine.UI;

public class ButtonOperationModes : MonoBehaviour
{
    [SerializeField] private EMenuState menuState;

    private Button button;

    private MenuStateMachine menuStateMachine;

    private void Awake()
    {
        button = GetComponent<Button>();
        menuStateMachine = transform.parent.parent.parent.GetComponentInChildren<MenuStateMachine>();
    }

    private void OnEnable() => button.onClick.AddListener(() => menuStateMachine.TransitionTo(menuState));

    private void OnDisable() => button.onClick.RemoveListener(() => menuStateMachine.TransitionTo(menuState));
}