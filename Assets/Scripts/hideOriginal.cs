using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideOriginal : MonoBehaviour {
    public GameObject hide;
	// Use this for initialization
	void Start () {
        hide.SetActive(false);
    }


    // Update is called once per frame
    void Update() {
    }
}
