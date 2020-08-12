using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csIdentity2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // 부모 축에 정렬이 이루어진다.
            this.transform.localRotation = Quaternion.identity;
        }
    }
}
