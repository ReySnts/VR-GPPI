using System.Collections.Generic;
using UnityEngine;

public class MenuStateMachine : MonoBehaviour
{
    private readonly Dictionary<EMenuState, IMenuState> menuDictionary;

#nullable enable
    private IMenuState? currentMenuState;
#nullable disable

    //private void Awake()
    //{
    //    var menus = transform.GetComponentsInChildren<IMenuState>();
    //    foreach (var eachMenu in menus) menuDictionary.Add(eachMenu.EMenuState, eachMenu);
    //}

    //private void OnEnable()
    //{
    //    foreach (var eachMenu in menuDictionary.Values) eachMenu.GameObject.SetActive(false);
    //}

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