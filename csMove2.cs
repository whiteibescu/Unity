using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMove2 : MonoBehaviour
{
    public float speed = 20f;
    int cnt = 0;

    void Update()
    {
        //Debug.Log("frame cnt: " + cnt++);
        // 키보드 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //Debug.Log("Horizontal : " + h);
        //Debug.Log("Vertical : " + v);

        // 컴퓨터 성능차이에 따른 이동 거리 보정
        // deltaTime : frame간의 시간차
        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        // 현재 위치를 기준으로 이동
        this.transform.Translate(Vector3.right * h);
        this.transform.Translate(Vector3.forward * v);
    }
}
