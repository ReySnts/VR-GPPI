using UnityEngine;
using UnityEngine.UI;

public class ButtonOperationModes : MonoBehaviour
{
    [SerializeField] private EMenuState menuState;

    private Button button;

    private IMenuStateMachine menuStateMachine;

    private void Awake()
    {
        button = GetComponent<Button>();
        menuStateMachine = transform.parent.parent.parent.GetComponentInChildren<IMenuStateMachine>();
        button.onClick.AddListener(() => menuStateMachine.TransitionTo(menuState));
    }

    private void OnDestroy()
    {
        button.onClick.RemoveAllListeners();
        menuStateMachine = null;
        button = null;
    }
}