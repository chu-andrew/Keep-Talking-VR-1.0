using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK
{
    public class bombInteract : VRTK_InteractableObject
    {
        private bool position = false;
        private Vector3 originalPosition;
        private Quaternion originalRotation;
        public float positionOffsetTolerance;
        private void Start()
        {
            originalPosition = this.transform.localPosition;
            originalRotation = this.transform.localRotation;
        }
        protected override void Update()
        {
            base.Update();
            /*
            if (transform.position != new Vector3(0.06568187f, 1.486162f, -6.755465f) && !IsGrabbed() && !position)
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
            transform.localEulerAngles = new Vector3(0, -90, 0);
            //transform.position = new Vector3(0.06568187f, 1.486162f, -6.755465f);
            transform.localPosition = originalPosition;
            transform.localRotation = originalRotation;
            position = false;
        }
    }
}
