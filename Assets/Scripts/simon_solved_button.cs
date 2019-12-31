using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;
using Assets.LSL4Unity.Scripts;

public class simon_solved_button : MonoBehaviour
{
    public List<Color> turnGreenButton;
    public GameObject myobject;
    private bool solved = false;
    private LSLMarkerStream marker;

    // Use this for initialization
    void Start()
    {
        marker = FindObjectOfType<LSLMarkerStream>();
        Color z = turnGreenButton[0];
        GetComponent<MeshRenderer>().material.color = z;
    }

    // Update is called once per frame
    void Update()
    {
        if (myobject.GetComponent<randomtextures>().clear && !solved)
        {
            marker.Write("button cleared at ", Time.time);
            Color x = turnGreenButton[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
    }
}
