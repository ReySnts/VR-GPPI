using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PowerSwitch : MonoBehaviour
{
    [SerializeField] private XRSimpleInteractable simpleInteractable;

    [SerializeField] private HMIMenu hMIMenu;

    [SerializeField] private Sprite tampilanAwal;

    [SerializeField] private GameObject buttonActivate;

    private IEnumerator WaitForStart()
    {
        yield return new WaitForSeconds(5f);
        AfterWait();
    }

    private void AfterWait()
    {
        hMIMenu.Set(tampilanAwal);
        buttonActivate.SetActive(true);
    }

    public void StartMachine()
    {
        StartCoroutine(WaitForStart());
    }
}