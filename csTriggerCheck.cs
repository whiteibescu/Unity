using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Trigger란?
 * 둘 물체의 접촉이 발생하는 것을 Trigger이라고 한다.
 * 1) 두 오브젝트 모두 Collider가 있어야한다.
 * 2) 둘 중에 하나는 Rigidbody가 있어야 한다.
 * 3) 둘 중에 어느 오브젝트지 isTrigger가 Check되어야 한다.
 * 4) 어느 오브젝트가 움직여서 부딪혀도 Trigger가 발생한다. 
 
 */

public class csTriggerCheck : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter : " + other.gameObject.name);
    }
        
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter : " + collision.gameObject.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
