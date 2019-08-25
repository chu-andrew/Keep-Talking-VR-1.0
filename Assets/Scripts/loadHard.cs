using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRTK
{
    public class loadHard : VRTK_InteractableObject
    {
        private bool position = false;
        private Vector3 originalPosition;
        private Quaternion originalRotation;
        public float positionOffsetTolerance;

        void Start()
        {
            originalPosition = this.transform.localPosition;
            originalRotation = this.transform.localRotation;
        }

        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            SteamVR_LoadLevel.Begin("Keep Talking Nobody Explodes hard");
        }

        protected override void Update()
        {
            base.Update();

            /* Delete the code to make the cube not being forcely placed in fix position*/
            //if (transform.position != new Vector3(-0.517f, 0.1703442f, 0.224f) && !IsGrabbed() && !position)
            //{
            //    StartCoroutine(ReturnPosition());
            //    position = true;
            //}
            if ((transform.position - originalPosition).magnitude > positionOffsetTolerance && !IsGrabbed() && !position)
            {
                StartCoroutine(ReturnPosition());
                position = true;
            }
        }
        IEnumerator ReturnPosition()
        {
            yield return new WaitForSeconds(4.0f);
            //transform.position = new Vector3(-0.517f, 0.1703442f, 0.224f);
            transform.localPosition = originalPosition;
            transform.localRotation = originalRotation;
            position = false;
        }
    }
}
