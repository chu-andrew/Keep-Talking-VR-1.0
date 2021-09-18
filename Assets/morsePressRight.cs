using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class morsePressRight : VRTK_InteractableObject
    {
        public GameObject morseCodeControl;
        private LSLMarkerStream marker;

        // Use this for initialization
        void Start()
        {
            marker = FindObjectOfType<LSLMarkerStream>();
        }

        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            morseCodeControl.GetComponent<morseCodeController>().changeRight();
            marker.Write("morse code right pressed at ");

        }
        void OnMouseDown()
        {
            morseCodeControl.GetComponent<morseCodeController>().changeRight();
            marker.Write("morse code right pressed at ");

        }
    }
}
