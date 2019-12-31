using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

public class SimonSolved : MonoBehaviour {
    public List<Color> turnGreen;
    public GameObject myObject;
    private bool solved = false;
    private LSLMarkerStream marker;

    // Use this for initialization
    void Start () {
        marker = FindObjectOfType<LSLMarkerStream>();
        Color z = turnGreen[0];
        GetComponent<MeshRenderer>().material.color = z;
    }
	
	// Update is called once per frame
	void Update () {
		if(myObject.GetComponent<SimonSaysModule>().round4 && !solved)
        {
            marker.Write("simon says cleared at ", Time.time);
            Color x = turnGreen[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
	}
}
