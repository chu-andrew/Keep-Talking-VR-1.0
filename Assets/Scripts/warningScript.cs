using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warningScript : MonoBehaviour {
    public Material newMaterialRef;
    public AudioClip siren;
    public AudioSource sirenSource;
    private bool startSiren = false;
    public Material ogMaterial;

    // Use this for initialization
    void Start () {
        sirenSource.clip = siren;
	}
    public void flashSiren()
    {
        StartCoroutine(flash());
    }
    // Update is called once per frame
    void Update () {
        if(countdown.mainTimer <= 30 && !startSiren)
        {
            sirenSource.Play();
            startSiren = true;
            flashSiren();
        }
	}
    IEnumerator flash()
    {
        yield return new WaitForSeconds(0.5f);
        GetComponent<Renderer>().material = newMaterialRef;
        yield return new WaitForSeconds(1f);
        GetComponent<Renderer>().material = ogMaterial;
    }
}
