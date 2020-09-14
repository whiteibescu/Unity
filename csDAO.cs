using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class csDAO : MonoBehaviour
 {
    private void OnGUI()
    {
        if (GUI.Button(new Rect(30, 50, 180, 30), "Set Value"))
            SetData();
        if (GUI.Button(new Rect(30, 100, 180, 30), "Get Value"))
            GetData();
    }

    void SetData()
    {
        PlayerPrefs.SetInt("Score", 98);
        PlayerPrefs.SetString("Name", "홍길동");

    }
    void GetData()
    {
        int score = PlayerPrefs.GetInt("Score");
        string name = PlayerPrefs.GetString("Name");

        if (EditorUtility.DisplayDialog("알림", "출력 내용 선택", "이름", "점수"))
            Debug.Log("Name : " + name);
        else
            Debug.Log("Score  : " + score);
    }
}
