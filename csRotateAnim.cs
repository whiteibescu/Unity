using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotateAnim : MonoBehaviour
{
    public Object mat1;
    public Object mat2;

    void frontImage()
    {
        GetComponent<Renderer>().material = (Material)mat1;
    }
    void backImage()
    {
        GetComponent<Renderer>().material = (Material)mat2;
    }
}
