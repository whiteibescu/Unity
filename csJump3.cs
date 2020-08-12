using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csJump3 : MonoBehaviour
{
    float gravity = 0f;
    Vector3 pos;
    bool isJump = false;
    void Start()
    {
        pos = transform.position;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gravity = 50f;
            isJump = true;
        }
        if (isJump)
        {
            pos.y += gravity * Time.deltaTime;
            transform.position = pos;
            gravity -= 0.5f;
            if(pos.y < 0.5f)
            {
                pos.y = 0.5f;
                transform.position = pos;
                gravity = 0f;
                isJump = false;
            }
        }

    }
}
