using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour {
    public Text uiCountdown;
    private bool startTimer = false;
    public static int mainTimer = 300;

    void Start()
    {
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }

    void Update()
    {
        if(!startTimer && switchCamera.difficulty != 0)
        {
            if(switchCamera.difficulty == 1)
            {
                mainTimer = 300;
            }
            if (switchCamera.difficulty == 2)
            {
                mainTimer = 200;
            }
            if (switchCamera.difficulty == 3)
            {
                mainTimer = 100;
            }
            if(switchCamera.difficulty == 4)
            {
                mainTimer = 2000;
            }
            if (switchCamera.difficulty == 5)
            {
                mainTimer = 120;
            }
            StartCoroutine("LoseTime");
            startTimer = true;
        }
        uiCountdown.text = ("" + mainTimer); //Showing the Score on the Canvas
    }
    //Simple Coroutine
    IEnumerator LoseTime()
    {
        while (mainTimer>0)
        {
            yield return new WaitForSeconds(1f);
            mainTimer--;
        }
    }
}
