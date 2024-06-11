using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MenuStateMachine : MonoBehaviour, IStateMachine<EMenuState>
{
    private readonly Dictionary<EMenuState, IMenuState> menuDictionary = new();

#nullable enable
    private IMenuState? currentMenuState;
#nullable disable

    private void Awake()
    {
        var menuStates = GetComponentsInChildren<IMenuState>().ToList();
        foreach (var eachMenu in menuStates) menuDictionary.Add(eachMenu.EMenuState, eachMenu);
    }

    private void OnEnable()
    {
        foreach (var eachMenu in menuDictionary) eachMenu.Value.GameObject.SetActive(false);
        TransitionTo(EMenuState.Operation);
    }

    public void TransitionTo(EMenuState nextState)
    {
        if (menuDictionary.ContainsKey(nextState))
        {
            currentMenuState?.GameObject.SetActive(false);
            currentMenuState = menuDictionary[nextState];
            currentMenuState.GameObject.SetActive(true);
        }
    }
}