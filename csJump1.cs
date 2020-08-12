using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csJump1 : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.GetComponent<Rigidbody>().velocity =
                Vector3.up * speed;
                //new Vector3(0, 1, 0) * speed;
                //new Vector3(0, speed, 0);
        }
    }
}
