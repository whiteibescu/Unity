using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.UI;

public class csChangeText : MonoBehaviour
{
    GameObject obj;
    Text txt;
    string[] names = { "홍길동", "임꺽정", "장길산", "일지매" };
    void Start()
    {
        obj = GameObject.Find("txtCenter");
        txt = obj.GetComponent<Text>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            StartCoroutine(coSetText());
    }
    IEnumerator coSetText()
    {
        foreach(string s in names)
        {
            yield return new WaitForSeconds(2f);
            changeText(s);            
        }
    }
    void changeText(string str)
    {
        txt.text = str;
    }
}
