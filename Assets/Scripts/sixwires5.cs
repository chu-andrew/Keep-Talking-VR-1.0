﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

namespace VRTK.Examples
{
    public class sixwires5 : VRTK_InteractableObject
    {

        public GameObject myObject;
        public GameObject wire6;
        public int choose6wires5;
        public List<Color> colors;
        private bool colorChosen = false;
        // Use this for initialization
        void Start() { }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            if (myObject.GetComponent<sixwires1>().scenario6wires == 1 && colors.Count > 0 && !colorChosen)
            {
                choose6wires5 = Random.Range(0, colors.Count);
                if (choose6wires5 == 1)
                {
                    while (choose6wires5 == 1)
                    {
                        choose6wires5 = Random.Range(0, colors.Count);
                    }
                }
                Color c = colors[choose6wires5];
                GetComponent<Renderer>().material.color = c;
            }
            if (myObject.GetComponent<sixwires1>().scenario6wires == 2 && colors.Count > 0 && !colorChosen)
            {
                if (myObject.GetComponent<sixwires1>().chooseYellow6 == 5)
                {
                    choose6wires5 = 1;
                    Color c = colors[choose6wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<sixwires1>().z1 == 5)
                {
                    choose6wires5 = 3;
                    Color c = colors[choose6wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<sixwires1>().z2 == 5)
                {
                    choose6wires5 = 3;
                    Color c = colors[choose6wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose6wires5 = Random.Range(0, colors.Count);
                    if (choose6wires5 == 1)
                    {
                        while (choose6wires5 == 1)
                        {
                            choose6wires5 = Random.Range(0, colors.Count);
                        }
                    }
                    Color c = colors[choose6wires5];
                    GetComponent<Renderer>().material.color = c;
                }
            }
            if (myObject.GetComponent<sixwires1>().scenario6wires == 3 && colors.Count > 0 && !colorChosen)
            {
                if (myObject.GetComponent<sixwires1>().yellowNum6 == 0 || (myObject.GetComponent<sixwires1>().yellowNum6 == 1 && myObject.GetComponent<sixwires1>().whiteNum6 > 1))
                {
                    choose6wires5 = 1;
                    Color c = colors[choose6wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<sixwires1>().whiteNum6 == 1)
                {
                    choose6wires5 = Random.Range(1, colors.Count);
                    if (choose6wires5 == 3)
                    {
                        while (choose6wires5 == 3)
                        {
                            choose6wires5 = Random.Range(1, colors.Count);
                        }
                    }
                    Color c = colors[choose6wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose6wires5 = Random.Range(1, colors.Count);
                    Color c = colors[choose6wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                if (choose6wires5 == 1)
                {
                    myObject.GetComponent<sixwires1>().yellowNum6 += 1;
                }
                if (choose6wires5 == 3)
                {
                    myObject.GetComponent<sixwires1>().whiteNum6 += 1;
                }
            }
            if (myObject.GetComponent<sixwires1>().scenario6wires == 4 && colors.Count > 0 && !colorChosen)
            {
                if (myObject.GetComponent<sixwires1>().yellowNum6 == 0 || (myObject.GetComponent<sixwires1>().yellowNum6 == 1 && myObject.GetComponent<sixwires1>().whiteNum6 > 1))
                {
                    choose6wires5 = 1;
                    Color c = colors[choose6wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (myObject.GetComponent<sixwires1>().whiteNum6 == 1)
                {
                    choose6wires5 = Random.Range(0, colors.Count);
                    if (choose6wires5 == 3)
                    {
                        while (choose6wires5 == 3)
                        {
                            choose6wires5 = Random.Range(0, colors.Count);
                        }
                    }
                    Color c = colors[choose6wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose6wires5 = Random.Range(0, colors.Count);
                    Color c = colors[choose6wires5];
                    GetComponent<Renderer>().material.color = c;
                }
                if (choose6wires5 == 0)
                {
                    myObject.GetComponent<sixwires1>().redNum6 += 1;
                }
                if (choose6wires5 == 1)
                {
                    myObject.GetComponent<sixwires1>().yellowNum6 += 1;
                }
                if (choose6wires5 == 3)
                {
                    myObject.GetComponent<sixwires1>().whiteNum6 += 1;
                }
            }
            colorChosen = true;
        }
        private void OnMouseDown()
        {
            if (myObject.GetComponent<sixwires1>().scenario6wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<sixwires1>().scenario6wires == 2)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<sixwires1>().scenario6wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<sixwires1>().scenario6wires == 4)
            {
                mistakes.mistakeNum += 1;
            }
            wire6.SetActive(false);
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            if (myObject.GetComponent<sixwires1>().scenario6wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<sixwires1>().scenario6wires == 2)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<sixwires1>().scenario6wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<sixwires1>().scenario6wires == 4)
            {
                mistakes.mistakeNum += 1;
            }
            wire6.SetActive(false);
        }
    }
}
