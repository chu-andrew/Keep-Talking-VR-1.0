using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memoryModuleClear : MonoBehaviour {

    public List<Color> turnGreen;
    public static bool clearMmemoryModule;

    // Use this for initialization
    void Start()
    {
        Color z = turnGreen[0];
        GetComponent<MeshRenderer>().material.color = z;
        clearMmemoryModule = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (clearMmemoryModule)
        {
            Color x = turnGreen[1];
            GetComponent<MeshRenderer>().material.color = x;
        }
    }
}
