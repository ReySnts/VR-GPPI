using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPassOuter : ButtonFunctionKeys
{
    [SerializeField] private InteractionLayerMask touchable;

    [SerializeField] private Material glow;

    [SerializeField] private ChamberHandle chamberHandle;

    private ITouchable Touchable => chamberHandle;

    private IRenderer Renderer => chamberHandle.GetComponentInChildren<IRenderer>();

    private void OnEnable() => button.onClick.AddListener(() => OnClick());

    private void OnClick()
    {
        Touchable.InteractionLayerMask = touchable;
        Touchable.SimpleInteractable.interactionLayers = touchable;
        Renderer.MeshRenderer.material = glow;
    }

    private void OnDisable() => button.onClick.RemoveListener(() => OnClick());
}