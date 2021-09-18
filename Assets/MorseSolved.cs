using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

public class MorseSolved : MonoBehaviour {

    public List<Color> turnGreen;
    public GameObject morsecontroller;
    private bool solved = false;
    private LSLMarkerStream marker;

    // Use this for initialization
    void Start()
    {
        marker = FindObjectOfType<LSLMarkerStream>();
        Color z = turnGreen[0];
        GetComponent<MeshRenderer>().material.color = z;
    }

    // Update is called once per frame
    void Update()
    {
        if (morsecontroller.GetComponent<morseCodeController>().correct && !solved)
        {
            marker.Write("morse code cleared at ");
            Color x = turnGreen[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
    }
}
