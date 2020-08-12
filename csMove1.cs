using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMove1 : MonoBehaviour
{
    // 초기화, 변수초기화, 동작초기화
    void Start()
    {
        // 절대위치로 이동
        //this.transform.position =
        //    new Vector3(0.0f, 1.5f, 0.0f);

        // 현재위치에서 상대적으로 이동
        //this.transform.Translate(
        //    new Vector3(0.0f, 0.0f, 1.0f));
        this.transform.Translate(
            Vector3.forward * 3.0f);
    }

    // 계속 호출
    void Update()
    {
        
    }
}
