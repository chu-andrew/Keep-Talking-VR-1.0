using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snoozeAlarm : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        alarmTimer.delayAlarm = true;
        transform.Translate(0, 0, -Time.deltaTime);
    }
    private void OnMouseUp()
    {
        transform.Translate(0, 0, Time.deltaTime);
    }
}
