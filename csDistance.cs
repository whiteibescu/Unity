using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csDistance : MonoBehaviour
{
    public Transform blueCube;
    public Transform redCube;
    public Transform greenCube;
    void Start()
    {
        // 두 Object사이의 거리 구하기 - 1 
        float distance1 =
            Vector3.Distance(blueCube.position,
                             greenCube.position);
        Debug.Log("distance1 : " + distance1);

        // 두 Object사이의 거리 구하기 - 2 
        float distance2 =
            (greenCube.position - blueCube.position).magnitude;
        Debug.Log("distance2 : " + distance2);

        // 방향을 구해서 해당 방향으로 회전
        Vector3 dir = redCube.position - blueCube.position;
        dir.Normalize();
        blueCube.eulerAngles = dir;
    }
}
