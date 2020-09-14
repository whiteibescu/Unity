using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class csChangeInput : MonoBehaviour
{
    Text txt;
    InputField input1;
    InputField input2;
    InputField input3;
    void Start()
    {
        txt = GameObject.Find("txtCenter").GetComponent<Text>();
        input1 = GameObject.Find("InputField1").GetComponent<InputField>();
        input2 = GameObject.Find("InputField2").GetComponent<InputField>();
        input3 = GameObject.Find("InputArea").GetComponent<InputField>();
    }
    public void changeValue()
    {
        if(input1.text.Length < 4)
        {
            // 모바일에서는 X
            if(EditorUtility.DisplayDialog("알림",
                "입력은 4자 이상해주세요", "확인"))
            {
                input1.Select();    // 커서 포커스 위치
            }
        }
        else
        {
            txt.text = input1.text;
        }

        Debug.Log("InputField1 : " + input1.text);
        Debug.Log("InputField2 : " + input2.text);
        Debug.Log("InputArea : " + input3.text);
    }

}
