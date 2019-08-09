using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarmTimer : MonoBehaviour {
    public List<Color> alarmColors;
    public static bool delayAlarm = true;
    private bool startTimer = false;

    // Use this for initialization
    void Start () {
        StartCoroutine(alarmCountdown());
    }

    // Update is called once per frame
    void Update () {
        if (!startTimer && switchCamera.difficulty != 0)
        {
            StartCoroutine(alarmCountdown());
            startTimer = true;
        }
    }
    IEnumerator alarmCountdown()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(100, 200));
            delayAlarm = false;
            Color z = alarmColors[0];
            Color x = alarmColors[1];
            Color y = alarmColors[2];
            while (!delayAlarm)
            {
                GetComponent<MeshRenderer>().material.color = z;
                yield return new WaitForSeconds(0.5f);
                GetComponent<MeshRenderer>().material.color = x;
                yield return new WaitForSeconds(0.01f);
            }
            GetComponent<MeshRenderer>().material.color = y;
        }
    }
}
