using UnityEngine;

public class ButtonActivate : ButtonScript
{
    [SerializeField] private GameObject panelLogin;

    public override void OnClick()
    {
        Button.interactable = false;
        Instantiate(original: panelLogin, parent: transform.parent);
    }
}