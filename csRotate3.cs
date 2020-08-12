using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotate3 : MonoBehaviour
{
    public float rotSpeed = 120f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * rotSpeed * Time.deltaTime;
        v = v * rotSpeed * Time.deltaTime;

        this.transform.Rotate(Vector3.up * h);
        this.transform.Rotate(Vector3.forward * v);
    }
}
