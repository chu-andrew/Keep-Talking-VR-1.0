using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRTK.Examples
{
    public class keypad3press : VRTK_InteractableObject
    {
        public GameObject myObject;
        public bool press3;
        public AudioClip soundEffect;
        public AudioSource source;
        // Use this for initialization
        void Start()
        {
            source.clip = soundEffect;
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            source.Play();
            press3 = true;
            //transform.Translate(Time.deltaTime, 0, 0);
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
            press3 = false;
            //transform.Translate(-Time.deltaTime, 0, 0);
            if (myObject.GetComponent<keypadimagecontroller>().wrongkeypad)
            {
                mistakes.mistakeNum += 1;
                myObject.GetComponent<keypadimagecontroller>().wrongkeypad = false;
            }
        }
        private void OnMouseDown()
        {
            press3 = true;
            transform.Translate(-Time.deltaTime, 0, 0);
        }
        void OnMouseUp()
        {
            press3 = false;
            transform.Translate(Time.deltaTime, 0, 0);
            if (myObject.GetComponent<keypadimagecontroller>().wrongkeypad)
            {
                mistakes.mistakeNum += 1;
                myObject.GetComponent<keypadimagecontroller>().wrongkeypad = false;
            }
        }
    }
}
