using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wire5clear : MonoBehaviour {

    public List<Color> turnGreenWire5;
    public bool clearwire5;
    private bool solved = false;

    // Use this for initialization
    void Start()
    {
        Color z = turnGreenWire5[0];
        GetComponent<MeshRenderer>().material.color = z;
        clearwire5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (clearwire5 && !solved)
        {
            Color x = turnGreenWire5[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
    }
}
