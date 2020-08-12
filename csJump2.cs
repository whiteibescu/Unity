using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csJump2 : MonoBehaviour
{
    public float power = 400f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.GetComponent<Rigidbody>().AddForce(
                Vector3.up * power);
        }
    }
}
