using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

public class TurnGreenKeypad : MonoBehaviour {
    public GameObject myObject;
    public List<Color> turnGreenKeypad;
    private bool solved = false;
    private LSLMarkerStream marker;

    // Use this for initialization
    void Start()
    {
        marker = FindObjectOfType<LSLMarkerStream>();
        Color z = turnGreenKeypad[0];
        GetComponent<MeshRenderer>().material.color = z;
    }

    // Update is called once per frame
    void Update()
    {
        if (myObject.GetComponent<keypadimagecontroller>().keypadClear && !solved)
        {
            marker.Write("keypad cleared at ", Time.time);
            Color x = turnGreenKeypad[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
    }
}
