using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csLookAt : MonoBehaviour
{
    Transform cube = null;

    /*씬내에 존재하는 다른 오브젝트 찾기*/
    //GameObject obj = GameObject.Find("RedCube");
    //Transform trfm = GameObject.Find("RedCube").transform;    
    void Start()
    {
        cube = GameObject.Find("RedCube").transform;
    }
    void Update()
    {
        // 주시
        this.transform.LookAt(cube);
    }
}
