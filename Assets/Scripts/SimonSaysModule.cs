using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

public class SimonSaysModule : MonoBehaviour {

    public flashyellow scriptY;
    public flashred scriptR;
    public flashblue scriptB;
    public flashgreen scriptG;
    public bool round1 = false;
    public bool round2 = false;
    public bool round3 = false;
    public bool round4 = false;
    public int rand;
    public int rand2;
    public int rand3;
    public int rand4;
    public bool button1 = false;
    public bool button2 = false;
    public bool button3 = false;
    public bool button4 = false;


    // Use this for initialization
    void Start () {
        StartCoroutine(repeatPattern());
    }
    void randSwitch(int num)
    {
        switch(num)
        {
            case 1:
                scriptY.flashY();
                break;
            case 2:
                scriptB.flashB();
                break;
            case 3:
                scriptR.flashR();
                break;
            case 4:
                scriptG.flashG();
                break;
        }
    }

    // Update is called once per frame
    void Update () {
    }
    IEnumerator repeatPattern()
    {
        button1 = false;
        button2 = false;
        button3 = false;
        button4 = false;
        rand = Random.Range(1, 4);
        while (!round1)
        {
            yield return new WaitForSeconds(3.0f);
            randSwitch(rand);
        }
        rand2 = Random.Range(1, 4);
        button1 = false;
        button2 = false;
        button3 = false;
        button4 = false;
        while (!round2)
        {
            yield return new WaitForSeconds(3.0f);
            randSwitch(rand);
            yield return new WaitForSeconds(1.5f);
            Debug.Log("round2");
            randSwitch(rand2);
        }
        rand3 = Random.Range(1, 4);
        button1 = false;
        button2 = false;
        button3 = false;
        while (!round3)
        {
            yield return new WaitForSeconds(3.0f);
            Debug.Log(rand2);
            randSwitch(rand);
            yield return new WaitForSeconds(1.5f);
            Debug.Log("round2");
            Debug.Log(rand2);
            randSwitch(rand2);
            yield return new WaitForSeconds(1.5f);
            Debug.Log("round3");
            Debug.Log(rand3);
            randSwitch(rand3);
        }
        rand4 = Random.Range(1, 4);
        button1 = false;
        button2 = false;
        button3 = false;
        button4 = false;
        while (!round4)
        {
            yield return new WaitForSeconds(3.0f);
            Debug.Log("round1");
            randSwitch(rand);
            yield return new WaitForSeconds(1.5f);
            Debug.Log("round2");
            Debug.Log(rand2);
            randSwitch(rand2);
            yield return new WaitForSeconds(1.5f);
            Debug.Log("round3");
            Debug.Log(rand3);
            randSwitch(rand3);
            yield return new WaitForSeconds(1.5f);
            Debug.Log("round4");
            Debug.Log(rand4);
            randSwitch(rand4);
        }
    }
}