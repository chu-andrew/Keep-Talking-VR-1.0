using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideSpeechToText : MonoBehaviour {
    public GameObject hide;
    public bool enabled;
    // Use this for initialization
    void Start () {
		if(!enabled) {
            hide.SetActive(false);
        } else {
            hide.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
