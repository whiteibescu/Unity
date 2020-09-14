using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csChangeButton : MonoBehaviour
{
    GameObject obj;
    Text txt;
    void Start()
    {
        obj = GameObject.Find("txtCenter");
        txt = obj.GetComponent<Text>();
    }
    public void changeText()
    {
        txt.text = "홍길동";
    }
    public void changeText(string name)
    {
        txt.text = name;
    }
}
