using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

public class morseCodeFlash : MonoBehaviour {

    public List<Color> flash;


    // Use this for initialization
    void Start () {
    }

    public IEnumerator FlashShort()
    {
        Color z = flash[0];
        Color x = flash[1];
        //Debug.Log("short");
        GetComponent<MeshRenderer>().material.color = x;
        yield return new WaitForSeconds(0.3f);
        GetComponent<MeshRenderer>().material.color = z;
        yield return new WaitForSeconds(0.2f);
    }
    public IEnumerator FlashLong()
    {
        Color z = flash[0];
        Color x = flash[1];
        //Debug.Log("long");
        GetComponent<MeshRenderer>().material.color = x;
        yield return new WaitForSeconds(2);
        GetComponent<MeshRenderer>().material.color = z;
        yield return new WaitForSeconds(0.2f);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
