using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotate1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 회전 1 (절대 각도)
        //this.transform.eulerAngles =
        //        new Vector3(0f, 50f, 0f);

        // 회전 2 (절대 각도)
        //Quaternion target =
        //    Quaternion.Euler(0f, 100f, 0f);
        //this.transform.rotation = target;

        // 회전 3 (현재각도를 기준으로 상대 각도)
        this.transform.Rotate(Vector3.up * 90f);
    }
}
