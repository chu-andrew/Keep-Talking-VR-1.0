using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRTK.Examples
{
    public class keypad2press : VRTK_InteractableObject
    {
        public GameObject myObject;
        public bool press2;
        public AudioClip soundEffect;
        public AudioSource source;

        // Use this for initialization
        void Start()
        {
            source.clip = soundEffect;
        }

        // Update is called once per frame
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            source.Play();
            press2 = true;
            //transform.Translate(Time.deltaTime, 0, 0);
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
            //transform.Translate(-Time.deltaTime, 0, 0);
            press2 = false;
            if (myObject.GetComponent<keypadimagecontroller>().wrongkeypad)
            {
                mistakes.mistakeNum += 1;
                myObject.GetComponent<keypadimagecontroller>().wrongkeypad = false;
            }
        }
        private void OnMouseDown()
        {
            press2 = true;
            transform.Translate(0, 0, -Time.deltaTime);
        }
        void OnMouseUp()
        {
            transform.Translate(0, 0, Time.deltaTime);
            press2 = false;
            if (myObject.GetComponent<keypadimagecontroller>().wrongkeypad)
            {
                mistakes.mistakeNum += 1;
                myObject.GetComponent<keypadimagecontroller>().wrongkeypad = false;
            }
        }
    }
}
