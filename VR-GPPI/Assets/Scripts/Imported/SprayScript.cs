using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayScript : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SprayOn()
    {
        anim.SetBool("Ditekan", true);
    }

    public void SprayOff()
    {
        anim.SetBool("Ditekan", false);
    }
}
