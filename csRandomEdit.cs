using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRandomEdit : MonoBehaviour
{
    void Start()
    {
        int myVal = 0;
        float nLimit = Mathf.Clamp(myVal, 1, 5);
        Debug.Log("Clamps : " + nLimit);

        int randomSeeds;
        randomSeeds = (int)System.DateTime.Now.Ticks;
        Random.InitState(randomSeeds);

        int randomX = Random.Range(5, 10);
        Debug.Log("Integer : " + randomX);

        float randomY = Random.Range(5f, 10f);
        Debug.Log("Float : " + randomY);
    }
}
