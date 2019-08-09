using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ventingcountdown : MonoBehaviour {

    public Text uiCountdown;
    public static float mainVentTimer = 60.0f;

    void Start()
    {
        mainVentTimer = 60.0f;
    }

    void Update()
    {
        uiCountdown.text = ("" + mainVentTimer); //Showing the Score on the Canvas
        uiCountdown.alignment = TextAnchor.MiddleCenter;
        uiCountdown.fontSize = 20;
        if(!ventingwarning.delay)
        {
            mainVentTimer -= Time.deltaTime;
            mainVentTimer = (float)(Math.Truncate((double)mainVentTimer * 100.0) / 100.0);
        }
    }
}
