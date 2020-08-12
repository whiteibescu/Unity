using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class csRotate2 : MonoBehaviour
{
    public float movSpeed = 20f;
    public float rotSpeed = 120f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * rotSpeed * Time.deltaTime;
        v = v * movSpeed * Time.deltaTime;

        this.transform.Translate(Vector3.forward * v);
        this.transform.Rotate(Vector3.up * h);
    }
}
