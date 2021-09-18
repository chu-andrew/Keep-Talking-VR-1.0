using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class morseCodeTextScript : MonoBehaviour {

    public Text ui;
    public string mhzText;

    // Use this for initialization
    void Start () {
        mhzText = "3.500";
	}
	
	// Update is called once per frame
	void Update () {
        ui.text = mhzText;
    }
}
