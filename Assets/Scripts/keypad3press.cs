using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRTK.Examples
{
    public class keypad3press : VRTK_InteractableObject
    {
        public GameObject myObject; //sets it to the keypad button in the game editor
        public bool press3; // if the object is pressed or not
        public AudioClip soundEffect;
        public AudioSource source;
        // Use this for initialization
        void Start()
        {
            source.clip = soundEffect; // sets sound effect
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null) // runs when the object is used, or when the controller is touching the object (keypad button) and is pressed (function adds onto the base VRTK library startUsing function)
        {
            base.StartUsing(currentUsingObject);
            source.Play(); // plays sound
            press3 = true; // public boolean press3 is true
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true) // when the trigger button is released after using the object (function adds onto the base VRTK library stopUsing function)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
            press3 = false;
            if (myObject.GetComponent<keypadimagecontroller>().wrongkeypad) //check if the keypad button pressed was the wrong keypad button
            {
                mistakes.mistakeNum += 1; // adds one to the mistake counter
                myObject.GetComponent<keypadimagecontroller>().wrongkeypad = false; // makes sure the error isn't counted twice
            }
        }
        //Mouse up and down functions that do the same thing as the start and stop using methods (they don't work in VR)
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
