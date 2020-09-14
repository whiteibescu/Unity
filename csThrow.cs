using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csThrow : MonoBehaviour
{
    public float speed = 15f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.GetComponent<Rigidbody>().velocity =
                new Vector3(0, 1, 1) * speed;
        }
    }
}
