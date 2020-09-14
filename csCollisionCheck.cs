using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
<충돌 조건>
    1) 두 오브젝트 모두 Collider(충돌체)가 있어야 한다.
    2) 둘중 하나는 rigidbody가 있어야한다
    3) Rigidbody를 가진 족이 움직여야 이벤트 발생한다.*/
public class csCollisionCheck : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        Debug.Log("OnCollisionEnter : " + name);      
        
        if (collision.gameObject.name != "Plane" &&
            collision.gameObject.name != "Wall" 
            )
        {
            this.transform.position = new Vector3(0.2f, 0.5f, 0f);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
