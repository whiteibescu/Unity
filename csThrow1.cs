using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csThrow1 : MonoBehaviour
{
    public float power = 400f;  // 힘의 상수값
    public Vector3 velocity = new Vector3(0f, 1f, 1f);// 힘의 방향
    // 화면의 작용을 표현할 때(불규칙적)
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // 투수가 공을 던지거나 타자가 공을 때리는 것
            // 앵그리버드
            this.GetComponent<Rigidbody>().AddForce(velocity * power);
        }
    }
    // 정확한 시간에 호출(프레임간 간격이 정확함)
    // 물리 계산
    //void FixedUpdate()
    //{
    //    if (Input.GetButtonDown("Fire1"))
    //    {
    //        // 투수가 공을 던지거나 타자가 공을 때리는 것
    //        this.GetComponent<Rigidbody>().AddForce(velocity * power);
    //    }
    //}
}
