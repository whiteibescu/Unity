using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csSelfRotate : MonoBehaviour
{
    public float speed = 120f;
    void Update()
    {
        this.transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
