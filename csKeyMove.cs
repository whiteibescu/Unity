using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csKeyMove : MonoBehaviour
{
    public float speed = 30f;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        //회전1
        //transform.Rotate(Vector3.back * h);
        //transform.Rotate(Vector3.right * v);

        //회전2
        transform.rotation *= Quaternion.AngleAxis(h, Vector3.forward);
        transform.rotation *= Quaternion.AngleAxis(v, Vector3.right); 
    }
}
