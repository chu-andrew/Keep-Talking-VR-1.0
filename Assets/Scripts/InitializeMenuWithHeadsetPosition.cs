using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class InitializeMenuWithHeadsetPosition : MonoBehaviour
{

    public Transform hmdObject;
    public Vector3 offsetFromHmd;

    private bool hasInitialized = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hasInitialized == false) // if menu does not initialized with position, start to set it in front of headset
        {
            StartCoroutine(SetHmdPosition());
        }

    }

    IEnumerator SetHmdPosition()
    {
        yield return new WaitForSeconds(0.8f); // set the latency to get the headset position.
        if (hmdObject == null)
        {
            hmdObject = VRTK_DeviceFinder.DeviceTransform(VRTK_DeviceFinder.Devices.Headset); // if not assign with specific headset, get headset transform form VRTK
        }
        else
        {
            // set this object to snap in front of headset
            this.gameObject.transform.position = new Vector3(hmdObject.position.x + offsetFromHmd.x, this.transform.position.y + offsetFromHmd.y, hmdObject.position.z + offsetFromHmd.z);

            hasInitialized = true;
            Destroy(this); // delete the script to prevent wasting memory to update over and over again
        }
    }
}