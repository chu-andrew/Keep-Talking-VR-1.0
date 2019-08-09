using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRTK
{
    public class loadHard : VRTK_InteractableObject
    {
        private bool position = false;
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            SteamVR_LoadLevel.Begin("Keep Talking Nobody Explodes hard");
        }
        protected override void Update()
        {
            base.Update();
            if (transform.position != new Vector3(-0.517f, 0.1703442f, 0.224f) && !IsGrabbed() && !position)
            {
                StartCoroutine(ReturnPosition());
                position = true;
            }
        }
        IEnumerator ReturnPosition()
        {
            yield return new WaitForSeconds(4.0f);
            transform.position = new Vector3(-0.517f, 0.1703442f, 0.224f);
            position = false;
        }
    }
}
