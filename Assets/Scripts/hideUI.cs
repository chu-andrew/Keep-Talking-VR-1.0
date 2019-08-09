using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideUI : MonoBehaviour {
    public GameObject hide;
	// Use this for initialization
	void Start () {
        hide.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		if(endCamera.gameLost || endCamera.gameWon)
        {
            hide.SetActive(false);
        }
	}
}
