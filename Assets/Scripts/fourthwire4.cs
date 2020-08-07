using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class fourthwire4 : VRTK_InteractableObject
    {
        public GameObject clear;
        public GameObject myObject;
        public GameObject wire;
        public List<Color> colors;
        public static int choose4wires1;
        private bool colorChosen = false;
        private LSLMarkerStream marker;

        // Use this for initialization
        void Start()
        {
            marker = FindObjectOfType<LSLMarkerStream>();
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            if (myObject.GetComponent<firstwire4>().scenario4wires == 1 && colors.Count > 0 && !colorChosen)
            {
                if (myObject.GetComponent<firstwire4>().randomRed1 == 4 || myObject.GetComponent<firstwire4>().randomRed2 == 4)
                {
                    choose4wires1 = 0;
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose4wires1 = Random.Range(0, colors.Count);
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                if (choose4wires1 == 1)
                {
                    myObject.GetComponent<firstwire4>().yellowNum = myObject.GetComponent<firstwire4>().yellowNum + 1;
                }
                if (choose4wires1 == 4)
                {
                    myObject.GetComponent<firstwire4>().blueNum = myObject.GetComponent<firstwire4>().blueNum + 1;
                }
                if (choose4wires1 == 0)
                {
                    myObject.GetComponent<firstwire4>().redNum = myObject.GetComponent<firstwire4>().redNum + 1;
                }
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 2 && colors.Count > 0 && !colorChosen)
            {
                choose4wires1 = 1;
                Color c = colors[choose4wires1];

                GetComponent<Renderer>().material.color = c;

            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 3 && colors.Count > 0 && !colorChosen)
            {
                if (myObject.GetComponent<firstwire4>().blue == 4)
                {
                    choose4wires1 = 4;
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<firstwire4>().redNum >= 1)
                {
                    choose4wires1 = Random.Range(1, 4);
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<firstwire4>().redNum == 0)
                {
                    choose4wires1 = Random.Range(0, 4);
                    if (choose4wires1 == 1)
                    {
                        while (choose4wires1 == 1)
                        {
                            choose4wires1 = Random.Range(0, 4);
                        }
                    }
                    Color c = colors[choose4wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    Debug.Log("how");
                    choose4wires1 = Random.Range(0, 4);
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                if (choose4wires1 == 1)
                {
                    myObject.GetComponent<firstwire4>().yellowNum = myObject.GetComponent<firstwire4>().yellowNum + 1;
                }
                if (choose4wires1 == 4)
                {
                    myObject.GetComponent<firstwire4>().blueNum = myObject.GetComponent<firstwire4>().blueNum + 1;
                }
                if (choose4wires1 == 0)
                {
                    myObject.GetComponent<firstwire4>().redNum = myObject.GetComponent<firstwire4>().redNum + 1;
                }
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 4 && colors.Count > 0 && !colorChosen)
            {
                if (myObject.GetComponent<firstwire4>().randomYellow1 == 4 || myObject.GetComponent<firstwire4>().randomYellow2 == 4)
                {
                    choose4wires1 = 1;
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;

                }
                else if (myObject.GetComponent<firstwire4>().redNum >= 1)
                {
                    choose4wires1 = Random.Range(1, 4);
                    Color c = colors[choose4wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<firstwire4>().redNum == 0)
                {
                    choose4wires1 = Random.Range(0, 4);
                    if (choose4wires1 == 1)
                    {
                        while (choose4wires1 == 1)
                        {
                            choose4wires1 = Random.Range(0, 4);
                        }
                    }
                    Color c = colors[choose4wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose4wires1 = Random.Range(0, 4);
                    Color c = colors[choose4wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                if (choose4wires1 == 1)
                {
                    myObject.GetComponent<firstwire4>().yellowNum = myObject.GetComponent<firstwire4>().yellowNum + 1;
                }
                if (choose4wires1 == 4)
                {
                    myObject.GetComponent<firstwire4>().blueNum = myObject.GetComponent<firstwire4>().blueNum + 1;
                }
                if (choose4wires1 == 0)
                {
                    myObject.GetComponent<firstwire4>().redNum = myObject.GetComponent<firstwire4>().redNum + 1;
                }
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 5 && colors.Count > 0 && !colorChosen)
            {
                if (myObject.GetComponent<firstwire4>().redNum >= 1 || myObject.GetComponent<firstwire4>().yellowNum >= 1)
                {
                    if (myObject.GetComponent<firstwire4>().blueNum == 1)
                    {
                        choose4wires1 = 4;
                        Color c = colors[choose4wires1];

                        GetComponent<Renderer>().material.color = c;
                    }
                    else
                    {
                        choose4wires1 = Random.Range(2, 4);
                        Color c = colors[choose4wires1];

                        GetComponent<Renderer>().material.color = c;
                    }
                }
                else if (myObject.GetComponent<firstwire4>().blueNum == 1)
                {
                    choose4wires1 = 4;
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<firstwire4>().redNum == 0)
                {
                    choose4wires1 = Random.Range(0, 4);
                    if (choose4wires1 == 1)
                    {
                        while (choose4wires1 == 1)
                        {
                            choose4wires1 = Random.Range(0, 4);
                        }
                    }
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose4wires1 = Random.Range(0, 4);
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                if (choose4wires1 == 1)
                {
                    myObject.GetComponent<firstwire4>().yellowNum = myObject.GetComponent<firstwire4>().yellowNum + 1;
                }
                if (choose4wires1 == 4)
                {
                    myObject.GetComponent<firstwire4>().blueNum = myObject.GetComponent<firstwire4>().blueNum + 1;
                }
                if (choose4wires1 == 0)
                {
                    myObject.GetComponent<firstwire4>().redNum = myObject.GetComponent<firstwire4>().redNum + 1;
                }
            }
            colorChosen = true;
        }
        private void OnMouseDown()
        {
            if (myObject.GetComponent<firstwire4>().scenario4wires == 1)
            {
                if (choose4wires1 == 0)
                {
                    clear.GetComponent<wire4clear>().clearwire4 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 2)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 4)
            {
                clear.GetComponent<wire4clear>().clearwire4 = true;
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 5)
            {
                mistakes.mistakeNum += 1;
            }
            wire.SetActive(false);
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            marker.Write("fourth wire (4 wires)" + " cut at ");
            if (myObject.GetComponent<firstwire4>().scenario4wires == 1)
            {
                if (choose4wires1 == 0)
                {
                    clear.GetComponent<wire4clear>().clearwire4 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 2)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 4)
            {
                clear.GetComponent<wire4clear>().clearwire4 = true;
            }
            if (myObject.GetComponent<firstwire4>().scenario4wires == 5)
            {
                mistakes.mistakeNum += 1;
            }
            wire.SetActive(false);
        }
    }
}
