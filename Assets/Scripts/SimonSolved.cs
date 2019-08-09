using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSolved : MonoBehaviour {
    public List<Color> turnGreen;
    public GameObject myObject;
    private bool solved = false;

    // Use this for initialization
    void Start () {
        Color z = turnGreen[0];
        GetComponent<MeshRenderer>().material.color = z;
    }
	
	// Update is called once per frame
	void Update () {
		if(myObject.GetComponent<SimonSaysModule>().round4 && !solved)
        {
            Color x = turnGreen[1];
            GetComponent<MeshRenderer>().material.color = x;
            switchCamera.modulesSolved += 1;
            solved = true;
        }
	}
}
