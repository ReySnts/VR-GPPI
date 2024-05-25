using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NozzleScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] ps;
    [SerializeField] private float time;
    [SerializeField] private Sprite hijau;
    [SerializeField] private Sprite merah;
    [SerializeField] private Image button;

    public void OpenH2O2()
    {
        for (int i = 0; i < ps.Length; i++)
        {
            ps[i].Play();
        }
        button.sprite = hijau;
        Invoke("CloseH2O2", time);
    }

    private void CloseH2O2()
    {
        for (int i = 0; i < ps.Length; i++)
        {
            ps[i].Stop();
        }
        button.sprite = merah;  
    }
}
