using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csThrow2 : MonoBehaviour
{
    public float speed = 7f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.GetComponent<Rigidbody>().velocity =
                new Vector3(0, 1, 1) * speed;
        }
        if (Input.GetButtonDown("Jump"))
        {
            this.GetComponent<Rigidbody>().velocity =
                Vector3.zero;   // new Vector3(0, 0, 0);
        }
    }
}
