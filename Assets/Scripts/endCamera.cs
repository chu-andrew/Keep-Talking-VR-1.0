using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

public class endCamera : MonoBehaviour {

    public static bool gameWon = false;
    public static bool gameLost = false;
    public Camera showEndCamera;
    public Camera firstPersonCamera;

    void Update()
    {
        /*
        if (clear.GetComponent<wire3clear>().clearwire3 && clear.GetComponent<wire4clear>().clearwire4 && clear.GetComponent<wire5clear>().clearwire5 && clear.GetComponent<wire6clear>().clearwire6 && myObject.GetComponent<keypadimagecontroller>().keypadClear && randomtextures.clear && myObject.GetComponent<SimonSaysModule>().round4)
        {
            firstPersonCamera.enabled = false;
            gameWon = true;
            showEndCamera.enabled = true;
        }
        */
        /*
        if (clear.GetComponent<wire3clear>().clearwire3 && clear.GetComponent<wire4clear>().clearwire4 && clear.GetComponent<wire5clear>().clearwire5 && clear.GetComponent<wire6clear>().clearwire6 && randomtextures.clear && myObject.GetComponent<SimonSaysModule>().round4)
        {
            firstPersonCamera.enabled = false;
            gameWon = true;
            showEndCamera.enabled = true;
        }
        
        else if (mistakes.mistakeNum >= 3 || countdown.mainTimer <= 0 || ventingcountdown.mainVentTimer <= 0)
        {
            firstPersonCamera.enabled = false;
            showEndCamera.enabled = true;
            gameLost = true;
        }
        */
    }
}
