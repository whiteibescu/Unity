using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotate : MonoBehaviour
{
    public float speed = 30f;
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
    public void speedUp()
    {
        speed += 10f;
    }

    public void speedDown()
    {
        speed -= 10f;   
    }
}
