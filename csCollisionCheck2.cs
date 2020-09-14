using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCollisionCheck2 : MonoBehaviour
{
    public float power = 1200f;

    IEnumerator coBaseState()
    {
        // 실행을 1초동안 하지 않을께
        yield return new WaitForSeconds(1.0f);

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {            
            GameObject wallObj = GameObject.Find("Wall");
            wallObj.GetComponent<BoxCollider>().isTrigger = true;
            Debug.Log("--- 원래 상태 회복함 ---");
            Debug.Log("isTrigger : " + true);
            Debug.Log("isKinematic : " + true);
            Debug.Log("------------------------");
            rb.isKinematic = true; // 물리엔진 동작하지 않음
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter : " + collision.gameObject.name);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            GameObject wallObj = GameObject.Find("Wall");
            wallObj.GetComponent<BoxCollider>().isTrigger = false;
            Debug.Log("isTrigger : " + false);

            Debug.Log("isKinematic : " + false);
            rb.isKinematic = false; // 물리엔진 동작
            rb.AddForce(new Vector3(0, 1, -1) * power);

           // StartCoroutine(coBaseState());
            //StartCoroutine("coBaseState");
        }
    }
}
