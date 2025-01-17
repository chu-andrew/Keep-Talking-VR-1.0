﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wire3clear : MonoBehaviour {

    public List<Color> turnGreenButton;
    public bool clearwire3;
    private bool solved = false;

    // Use this for initialization
    void Start()
    {
        Color z = turnGreenButton[0];
        GetComponent<MeshRenderer>().material.color = z;
        clearwire3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (clearwire3 && !solved)
        {
            Color x = turnGreenButton[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
    }
}
