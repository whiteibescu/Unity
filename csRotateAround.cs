using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotateAround : MonoBehaviour
{
    Transform cube;
    public float speed = 40f;
    void Start()
    {
        cube = GameObject.Find("BlueCube").transform;
    }
    void Update()
    {
        this.transform.RotateAround(cube.position,
                        Vector3.up, speed * Time.deltaTime);

        this.transform.LookAt(cube);
    }
}
