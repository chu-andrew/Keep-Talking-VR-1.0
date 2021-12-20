using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class pianoKeysGSharp : VRTK_InteractableObject
    {
        public GameObject myObject;
        public AudioClip soundEffect;
        public AudioSource source;
        private LSLMarkerStream marker;
        public bool press = false;
        public bool pressedInInstant = false;
        public GameObject Controller;

        // Use this for initialization
        void Start()
        {
            // source.clip = soundEffect;
            marker = FindObjectOfType<LSLMarkerStream>();
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            // source.Play();
            pressedInInstant = true;
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            if (pressedInInstant)
            {
                Controller.GetComponent<pianokeyscontroller>().interrupted = true;
                press = true;
                marker.Write("piano key GSharp pressed");
                //transform.Translate(Time.deltaTime, 0, 0);
                SoundManagerScript.PlaySound("GSharpPlayed");
                pressedInInstant = false;
            }

            else if (!pressedInInstant)
            {
                base.StopUsing(previousUsingObject, resetUsingObjectState);
                press = false;
                //transform.Translate(-Time.deltaTime, 0, 0);
            }
        }
    }
}
