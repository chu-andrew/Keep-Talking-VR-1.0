using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour {
    private float changeTime = 0f;
    private Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Time.time > changeTime)
        {
            myLight.enabled = !myLight.enabled;
            if (myLight.enabled)
            {
                changeTime = Time.time + Random.Range(-10.0f, 10.0f);
            }
            else
            {
                changeTime = Time.time + Random.Range(-2.0f, 1.0f);
            }
        }
    }
}
