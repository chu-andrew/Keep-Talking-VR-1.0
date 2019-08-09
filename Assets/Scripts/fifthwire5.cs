using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

namespace VRTK.Examples
{
    public class fifthwire5 : VRTK_InteractableObject
    {
        public GameObject clear;
        public GameObject myObject;
        public GameObject wire5;
        public int choose5wires5;
        public List<Color> colors;
        private bool colorPicked = false;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            if (myObject.GetComponent<firstwire5>().scenario5wires == 1 && colors.Count > 0 && !colorPicked)
            {
                choose5wires5 = 2;
                Color c = colors[choose5wires5];
                GetComponent<Renderer>().material.color = c;
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 2 && colors.Count > 0 && !colorPicked)
            {
                if (myObject.GetComponent<firstwire5>().chooseRed == 5)
                {
                    choose5wires5 = 0;
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<firstwire5>().i1 == 5)
                {
                    choose5wires5 = 1;
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<firstwire5>().i2 == 5)
                {
                    choose5wires5 = 1;
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose5wires5 = 2;
                    while (choose5wires5 == 2)
                    {
                        choose5wires5 = Random.Range(0, colors.Count);
                    }
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 3 && colors.Count > 0 && !colorPicked)
            {
                if (myObject.GetComponent<firstwire5>().redNum5 == 1 && myObject.GetComponent<firstwire5>().yellowNum5 > 1)
                {
                    choose5wires5 = 0;
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else if ((myObject.GetComponent<firstwire5>().redNum5 == 1 && myObject.GetComponent<firstwire5>().yellowNum5 == 1) || (myObject.GetComponent<firstwire5>().redNum5 == 1))
                {
                    choose5wires5 = Random.Range(0, colors.Count);
                    if (choose5wires5 == 1 || choose5wires5 == 2)
                    {
                        while (choose5wires5 == 1 || choose5wires5 == 2)
                        {
                            choose5wires5 = Random.Range(0, colors.Count);
                        }
                    }
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<firstwire5>().yellowNum5 > 1)
                {
                    choose5wires5 = Random.Range(1, colors.Count);
                    if (choose5wires5 == 2)
                    {
                        while (choose5wires5 == 2)
                        {
                            choose5wires5 = Random.Range(1, colors.Count);
                        }
                    }
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose5wires5 = Random.Range(0, colors.Count);
                    if (choose5wires5 == 2)
                    {
                        while (choose5wires5 == 2)
                        {
                            choose5wires5 = Random.Range(0, colors.Count);
                        }
                    }
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                if (choose5wires5 == 0)
                {
                    myObject.GetComponent<firstwire5>().redNum5 += 1;
                }
                if (choose5wires5 == 1)
                {
                    myObject.GetComponent<firstwire5>().yellowNum5 += 1;
                }
            }
            if (myObject.GetComponent<firstwire5>().scenario5wires == 4 && colors.Count > 0 && !colorPicked)
            {
                if (myObject.GetComponent<firstwire5>().redNum5 == 1 && myObject.GetComponent<firstwire5>().yellowNum5 > 1)
                {
                    choose5wires5 = 0;
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else if ((myObject.GetComponent<firstwire5>().redNum5 == 1 && myObject.GetComponent<firstwire5>().yellowNum5 == 1) || (myObject.GetComponent<firstwire5>().redNum5 == 1))
                {
                    choose5wires5 = Random.Range(0, colors.Count);
                    if (choose5wires5 == 1 || choose5wires5 == 2)
                    {
                        while (choose5wires5 == 1 || choose5wires5 == 2)
                        {
                            choose5wires5 = Random.Range(0, colors.Count);
                        }
                    }
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<firstwire5>().yellowNum5 > 1)
                {
                    choose5wires5 = Random.Range(1, colors.Count);
                    if (choose5wires5 == 2)
                    {
                        while (choose5wires5 == 2)
                        {
                            choose5wires5 = Random.Range(1, colors.Count);
                        }
                    }
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose5wires5 = Random.Range(0, colors.Count);
                    if (choose5wires5 == 2)
                    {
                        while (choose5wires5 == 2)
                        {
                            choose5wires5 = Random.Range(0, colors.Count);
                        }
                    }
                    Color c = colors[choose5wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                if (choose5wires5 == 0)
                {
                    myObject.GetComponent<firstwire5>().redNum5 += 1;
                }
                if (choose5wires5 == 1)
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
                mistakes.mistakeNum += 1;
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
            if (myObject.GetComponent<firstwire5>().scenario5wires == 1)
            {
                mistakes.mistakeNum += 1;
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
