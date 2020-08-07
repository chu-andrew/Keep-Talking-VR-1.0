using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;
using Assets.LSL4Unity.Scripts;

public class wire6clear : MonoBehaviour {

    public List<Color> turnGreenWire6;
    public bool clearwire6;
    private bool solved = false;
    private LSLMarkerStream marker;

    // Use this for initialization
    void Start()
    {
        marker = FindObjectOfType<LSLMarkerStream>();
        Color z = turnGreenWire6[0];
        GetComponent<MeshRenderer>().material.color = z;
        clearwire6 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (clearwire6 && !solved)
        {
            marker.Write("wire 6 cleared at ");
            Color x = turnGreenWire6[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
    }
}
