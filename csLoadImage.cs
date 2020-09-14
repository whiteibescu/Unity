using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csLoadImage : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            object[] images =
                Resources.LoadAll("Images");
            RawImage[] raws = GameObject.Find("Canvas").
                transform.GetComponentsInChildren<RawImage>();
            for(int i=0;i<raws.Length;i++)
            {
                raws[i].texture = (Texture)images[i];
            }
        }
    }
}
