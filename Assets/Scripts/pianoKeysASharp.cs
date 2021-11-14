using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class pianoKeysASharp : VRTK_InteractableObject
    {
        public GameObject myObject;
        public AudioClip soundEffect;
        public AudioSource source;
        private LSLMarkerStream marker;
        public bool press1;
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
            press1 = true;
            marker.Write("piano key ASharp pressed");
            //transform.Translate(Time.deltaTime, 0, 0);
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
            press1 = false;
            //transform.Translate(-Time.deltaTime, 0, 0);
            if (myObject.GetComponent<pianokeyscontroller>().wrongkey)
            {
                mistakes.mistakeNum += 1;
                myObject.GetComponent<pianokeyscontroller>().wrongkey = false;
            }
        }
        private void OnMouseDown()
        {
            press1 = true;
            transform.Translate(0, 0, -Time.deltaTime);
        }
        void OnMouseUp()
        {
            press1 = false;
            transform.Translate(0, 0, Time.deltaTime);
            if (myObject.GetComponent<pianokeyscontroller>().wrongkey)
            {
                mistakes.mistakeNum += 1;
                myObject.GetComponent<pianokeyscontroller>().wrongkey = false;
            }
        }
    }
}
