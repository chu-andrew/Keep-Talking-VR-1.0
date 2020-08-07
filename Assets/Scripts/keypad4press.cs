using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class keypad4press : VRTK_InteractableObject
    {
        public GameObject myObject;
        public bool press4;
        public AudioClip soundEffect;
        public AudioSource source;
        private LSLMarkerStream marker;

        // Use this for initialization
        void Start()
        {
            source.clip = soundEffect;
            marker = FindObjectOfType<LSLMarkerStream>();
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            source.Play();
            press4 = true;
            marker.Write("keypad button 4 pressed at ");
            //transform.Translate(Time.deltaTime, 0, 0);
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
            //transform.Translate(-Time.deltaTime, 0, 0);
            press4 = false;
            if (myObject.GetComponent<keypadimagecontroller>().wrongkeypad)
            {
                mistakes.mistakeNum += 1;
                myObject.GetComponent<keypadimagecontroller>().wrongkeypad = false;
            }
        }
        // Update is called once per frame
        private void OnMouseDown()
        {
            press4 = true;
            transform.Translate(-Time.deltaTime, 0, 0);

        }
        void OnMouseUp()
        {
            transform.Translate(Time.deltaTime, 0, 0);
            press4 = false;
            if (myObject.GetComponent<keypadimagecontroller>().wrongkeypad)
            {
                mistakes.mistakeNum += 1;
                myObject.GetComponent<keypadimagecontroller>().wrongkeypad = false;
            }
        }
    }
}
