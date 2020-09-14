using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csChangeToggle : MonoBehaviour
{
    Text txt;
    GameObject toggleObj;
    Toggle tgChangeText;
    void Start()
    {
        txt = GameObject.Find("txtCenter").GetComponent<Text>();
        toggleObj = GameObject.Find("tgChangeText");
        tgChangeText = toggleObj.GetComponent<Toggle>();
    }

    public void changeText()
    {
        if (tgChangeText.isOn)
            txt.text = "Hello World";
        else
            txt.text = "홍길동";
    }
}
