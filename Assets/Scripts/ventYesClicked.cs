﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRTK.Examples
{
    public class ventYesClicked : VRTK_InteractableObject
    {

        public AudioClip soundEffect;
        public AudioSource source;

        public static bool isPressed = false;
        // Use this for initialization
        void Start()
        {
            source.clip = soundEffect;
        }

        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            source.Play();
            if (ventingwarning.chooseText == 1)
            {
                ventingwarning.delay = true;
            }
            if (ventingwarning.chooseText == 2)
            {
                mistakes.mistakeNum += 1;
            }
        }
        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
        }
        private void OnMouseDown()
        {
            transform.Translate(0, 0, -Time.deltaTime);
            if (ventingwarning.chooseText == 1)
            {
                ventingwarning.delay = true;
            }
            if (ventingwarning.chooseText == 2)
            {
                mistakes.mistakeNum += 1;
            }
        }
        private void OnMouseUp()
        {
            transform.Translate(0, 0, Time.deltaTime);
        }
    }
}
