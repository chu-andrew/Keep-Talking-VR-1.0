using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

namespace VRTK
{
    public class loadEasy : VRTK_InteractableObject
    {
        private LSLMarkerStream marker;
        private bool position = false;
        private Vector3 originalPosition;
        private bool pressed;
        private Quaternion originalRotation;
        public float positionOffsetTolerance;
        private void Start()
        {
            pressed = false;
            marker = FindObjectOfType<LSLMarkerStream>();
            originalPosition = this.transform.localPosition;
            originalRotation = this.transform.localRotation;
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            if(!pressed)
            {
                marker.Write("2 min test" + " starts");
                pressed = true;
            }
            SteamVR_LoadLevel.Begin("Keep Talking Nobody Explodes test 2");
        }
        protected override void Update()
        {
            base.Update();
            /*
            if (transform.position != new Vector3(-0.517f, 0.1703442f, -0.621f) && !IsGrabbed() && !position)
            {
                StartCoroutine(ReturnPosition());
                position = true;
            }
            */
            if ((transform.position - originalPosition).magnitude > positionOffsetTolerance && !IsGrabbed() && !position)
            {
                StartCoroutine(ReturnPosition());
                position = true;
            }
        }
        IEnumerator ReturnPosition()
        {
            yield return new WaitForSeconds(4.0f);
            //transform.position = new Vector3(-0.517f, 0.1703442f, -0.621f);
            transform.localPosition = originalPosition;
            transform.localRotation = originalRotation;
            position = false;
        }
    }
}
