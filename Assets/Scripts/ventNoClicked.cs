using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class ventNoClicked : VRTK_InteractableObject
    {
        // declaring variables
        public AudioClip soundEffect;
        public AudioSource source;
        private LSLMarkerStream marker;

        public static bool isPressed = false; 
        void Start()
        {
            source.clip = soundEffect;  // initializing variables
            marker = FindObjectOfType<LSLMarkerStream>();
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        { // uses the object, checks if button pressed was correct, and prints out time when pressed to markerstream
            base.StartUsing(currentUsingObject);
            marker.Write("venting gas no button pressed at ");
            source.Play();
            if (ventingwarning.chooseText == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (ventingwarning.chooseText == 2)
            {
                ventingwarning.delay = true;
            }
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState); // stop using the object so button can be pressed again
        }
        //same functions but for mouse clicking
        private void OnMouseDown()
        {
            transform.Translate(0, 0, -Time.deltaTime);
            if (ventingwarning.chooseText == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (ventingwarning.chooseText == 2)
            {
                ventingwarning.delay = true;
            }

        }
        private void OnMouseUp()
        {
            transform.Translate(0, 0, Time.deltaTime);
        }
    }
}
