using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class checkMorse : VRTK_InteractableObject
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
            morseCodeControl.GetComponent<morseCodeController>().checkSolution();
            marker.Write("morse submit pressed at ");

        }
        void OnMouseDown()
        {
            morseCodeControl.GetComponent<morseCodeController>().checkSolution();
            marker.Write("morse submit pressed at ");
        }
    }
}
