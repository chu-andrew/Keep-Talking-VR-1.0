using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

public class TurnGreenPianoKeys : MonoBehaviour {
    public GameObject myObject;
    public List<Color> turnGreenPianoKeys;
    private bool solved = false;
    private LSLMarkerStream marker;

    // Use this for initialization
    void Start()
    {
        marker = FindObjectOfType<LSLMarkerStream>();
        Color z = turnGreenPianoKeys[0];
        GetComponent<MeshRenderer>().material.color = z;
    }

    // Update is called once per frame
    void Update()
    {
        if (myObject.GetComponent<pianokeyscontroller>().pianoClear && !solved)
        {
            marker.Write("keypad cleared at ", Time.time);
            Color x = turnGreenPianoKeys[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
    }
}
