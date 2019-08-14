using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventingwarning : MonoBehaviour {
    public List<Color> ventColors;
    public static int chooseText = 0;
    public static bool delay = true;
    private bool startTimer = false;
    public AudioClip beepClip;
    public AudioSource beep;
    // Use this for initialization
    void Start () {
        delay = true;
        beep.clip = beepClip;
    }

    // Update is called once per frame
    void Update () {
        if (!startTimer && switchCamera.difficulty != 0)
        {
            StartCoroutine(WarnVent());
            startTimer = true;
        }
    }
    IEnumerator WarnVent()
    {
        while(ventingcountdown.mainVentTimer > 0)
        {
            yield return new WaitForSeconds(Random.Range(30, 50));
            beep.Play();
            delay = false;
            chooseText = Random.Range(1,3);
            Debug.Log(chooseText);
            Color z = ventColors[0];
            Color x = ventColors[1];
            Color y = ventColors[2];
            while (!delay)
            {
                GetComponent<MeshRenderer>().material.color = z;
                yield return new WaitForSeconds(0.5f);
                GetComponent<MeshRenderer>().material.color = x;
                yield return new WaitForSeconds(0.01f);
            }
            chooseText = 0;
            GetComponent<MeshRenderer>().material.color = y;
        }
    }
}
