using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

public class wire4clear : MonoBehaviour {

    public List<Color> turnGreenButton;
    public bool clearwire4;
    private bool solved = false;
    private LSLMarkerStream marker;

    // Use this for initialization
    void Start()
    {
        marker = FindObjectOfType<LSLMarkerStream>();
        Color z = turnGreenButton[0];
        GetComponent<MeshRenderer>().material.color = z;
        clearwire4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (clearwire4 && !solved)
        {
            marker.Write("wire 4 cleared at ");
            Color x = turnGreenButton[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
    }
}
