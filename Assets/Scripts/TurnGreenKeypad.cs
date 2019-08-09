using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnGreenKeypad : MonoBehaviour {
    public GameObject myObject;
    public List<Color> turnGreenKeypad;
    private bool solved = false;

    // Use this for initialization
    void Start()
    {
        Color z = turnGreenKeypad[0];
        GetComponent<MeshRenderer>().material.color = z;
    }

    // Update is called once per frame
    void Update()
    {
        if (myObject.GetComponent<keypadimagecontroller>().keypadClear && !solved)
        {
            Color x = turnGreenKeypad[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
    }
}
