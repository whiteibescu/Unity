﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csChangeLabel : MonoBehaviour
{
    Text lbl;
    void Start()
    {
        lbl = GetComponent<Text>();
    }
    public void UpdateLabel(float value)
    {
        if (lbl != null)
            lbl.text = string.Format("{0:0.00}", value);
    }
}
