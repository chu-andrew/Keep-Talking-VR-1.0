using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class fourthwire5 : VRTK_InteractableObject
    {
        public GameObject clear;
        public GameObject myObject;
        public GameObject wire5;
        public int choose5wires4;
        public List<Color> colors;
        private LSLMarkerStream marker;
        private bool colorPicked = false;
        // Use this for initialization
        void Start()
        {
            marker = FindObjectOfType<LSLMarkerStream>();
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            if (myObject.GetComponent<firstwire5>().scenario5wires == 1 && colors.Count > 0 && !colorPicked)
            {
                choose5wires4 = Random.Range(0, colors.Count);
                Color c = colors[choose5wires4];
                GetComponent<Renderer>().material.color = c;
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 2 && colors.Count > 0 && !colorPicked)
            {
                if (myObject.GetComponent<firstwire5>().chooseRed == 4)
                {
                    choose5wires4 = 0;
                    Color c = colors[choose5wires4];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<firstwire5>().i1 == 4)
                {
                    choose5wires4 = 1;
                    Color c = colors[choose5wires4];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<firstwire5>().i2 == 4)
                {
                    choose5wires4 = 1;
                    Color c = colors[choose5wires4];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose5wires4 = Random.Range(1, colors.Count);
                    Color c = colors[choose5wires4];
                    GetComponent<Renderer>().material.color = c;
                }
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 3 && colors.Count > 0 && !colorPicked)
            {
                choose5wires4 = Random.Range(0, colors.Count);
                if (choose5wires4 == 2)
                {
                    while (choose5wires4 == 2)
                    {
                        choose5wires4 = Random.Range(0, colors.Count);
                    }
                }
                if (choose5wires4 == 0)
                {
                    myObject.GetComponent<firstwire5>().redNum5 += 1;
                }
                if (choose5wires4 == 1)
                {
                    myObject.GetComponent<firstwire5>().yellowNum5 += 1;
                }
                Color c = colors[choose5wires4];
                GetComponent<Renderer>().material.color = c;
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 4 && colors.Count > 0 && !colorPicked)
            {
                if (myObject.GetComponent<firstwire5>().blackNum5 == 0)
                {
                    choose5wires4 = 2;
                    Color c = colors[choose5wires4];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose5wires4 = Random.Range(0, colors.Count);
                    Color c = colors[choose5wires4];
                    GetComponent<Renderer>().material.color = c;
                }
                if (choose5wires4 == 2)
                {
                    myObject.GetComponent<firstwire5>().blackNum5 += 1;
                }
                if (choose5wires4 == 0)
                {
                    myObject.GetComponent<firstwire5>().redNum5 += 1;
                }
                if (choose5wires4 == 1)
                {
                    myObject.GetComponent<firstwire5>().yellowNum5 += 1;
                }
            }
            colorPicked = true;
        }
        private void OnMouseDown()
        {
            if (myObject.GetComponent<firstwire5>().scenario5wires == 1)
            {
                clear.GetComponent<wire5clear>().clearwire5 = true;
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 2)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 4)
            {
                mistakes.mistakeNum += 1;
            }
            wire5.SetActive(false);
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            marker.Write("fourth wire (5 wires)" + " cut at ", Time.time);
            if (myObject.GetComponent<firstwire5>().scenario5wires == 1)
            {
                clear.GetComponent<wire5clear>().clearwire5 = true;
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 2)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 4)
            {
                mistakes.mistakeNum += 1;
            }
            wire5.SetActive(false);
        }
    }
}
