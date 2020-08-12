using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csIdentity1 : MonoBehaviour
{
    void Update()
    {
        // 마우스 왼쪽 버튼
        if (Input.GetButtonDown("Fire1"))
        {
            // 월드(Global)좌표축에 정렬
            this.transform.rotation = Quaternion.identity;

            // 부모축에 정렬
            //this.transform.localRotation = Quaternion.identity;
        }
    }
}
