using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK
{
    public class retry : VRTK_InteractableObject
    {
        private bool position = false;
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            SteamVR_LoadLevel.Begin("Start Scene");
        }
        protected override void Update()
        {
            base.Update();

            /* Delete the code to make the cube not being forcely placed in fix position*/
            //if (transform.position != new Vector3(-0.517f, 0.1703442f, -0.261f) && !IsGrabbed() && !position)
            //{
            //    StartCoroutine(ReturnPosition());
            //    position = true;
            //}
        }
        IEnumerator ReturnPosition()
        {
            yield return new WaitForSeconds(4.0f);
            transform.position = new Vector3(-0.517f, 0.1703442f, -0.261f);
            position = false;
        }
    }
}
