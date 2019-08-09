using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK
{
    public class bombInteract : VRTK_InteractableObject
    {
        private bool position = false;
        protected override void Update()
        {
            base.Update();
            if (transform.position != new Vector3(0.06568187f, 1.486162f, -6.755465f) && !IsGrabbed() && !position)
            {
                StartCoroutine(ReturnPosition());
                position = true;
            }
        }
        IEnumerator ReturnPosition()
        {
            yield return new WaitForSeconds(4.0f);
            transform.position = new Vector3(0.06568187f, 1.486162f, -6.755465f);
            position = false;
        }
    }
}
