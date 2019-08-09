using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roundCoiunter : MonoBehaviour {
    public Text text;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        text.alignment = TextAnchor.MiddleCenter;
        text.fontSize = 20;
        text.text = ("" + chooseMemoryNum.roundNum);
    }
}
