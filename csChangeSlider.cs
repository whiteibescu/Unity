using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csChangeSlider : MonoBehaviour
{
    Text txt;
    Slider slider1;
    Slider slider2;
    int fontSize;
    void Start()
    {
        txt = GameObject.Find("txtCenter").GetComponent<Text>();
        slider1 = GameObject.Find("Slider1").GetComponent<Slider>();
        slider2 = GameObject.Find("Slider2").GetComponent<Slider>();

        this.fontSize = txt.fontSize;
    }
    public void changeSliderValue()
    {
        float val = slider2.value;
        slider1.value = val;
        txt.fontSize = fontSize + (int)val*2;
    }    
}
