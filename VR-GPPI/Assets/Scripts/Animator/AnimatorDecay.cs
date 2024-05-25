using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatorDecay : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private float detik;
    [SerializeField] private Sprite hijau;
    [SerializeField] private Sprite merah;
    [SerializeField] private Image button;

    private void Start()
    {
        anim = GetComponent<Animator>();  
    }

    public void Inflated()
    {
        anim.SetBool("Inflated", true);
        button.sprite = hijau;
        Invoke("Deflated", detik);
    }

    private void Deflated()
    {
        anim.SetBool("Inflated", false);
        button.sprite = merah;
    }
}
