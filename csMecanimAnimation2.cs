using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMecanimAnimation2 : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        anim.SetFloat("speed", v);
        anim.SetFloat("direction", h);
    }
}
