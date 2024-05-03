using UnityEngine;
using UnityEngine.UI;

public class MenuLogin : MonoBehaviour
{
    [SerializeField] private Button buttonActivate;

    [SerializeField] private GameObject menuMain;

    private void OnEnable() => buttonActivate.onClick.AddListener(() => { menuMain.SetActive(false); });

    private void OnDisable() => buttonActivate.onClick.RemoveListener(() => { menuMain.SetActive(false); });
}