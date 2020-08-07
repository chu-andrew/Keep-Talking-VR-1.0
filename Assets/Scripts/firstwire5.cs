using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class firstwire5 : VRTK_InteractableObject
    {
        public GameObject clear;
        public int scenario5wires;
        public GameObject first5wire;
        public int choose5wires1;
        public int chooseRed;
        public int blackNum5 = 0;
        public int i1;
        public int i2;
        public int redNum5 = 0;
        public int yellowNum5 = 0;
        public List<Color> colors;
        private LSLMarkerStream marker;
        // Use this for initialization
        void Start()
        {
            marker = FindObjectOfType<LSLMarkerStream>();
            i1 = Random.Range(1, 6);
            i2 = Random.Range(1, 6);
            if (i1 == i2)
            {
                while (i1 == i2)
                {
                    i2 = Random.Range(1, 6);
                }
            }
            chooseRed = Random.Range(1, 6);
            if (chooseRed == i1 || chooseRed == i2)
            {
                while (chooseRed == i1 || chooseRed == i2)
                {
                    chooseRed = Random.Range(1, 6);
                }
            }
            scenario5wires = Random.Range(1, 5);
            if (scenario5wires == 1 && colors.Count > 0)
            {
                choose5wires1 = Random.Range(0, colors.Count);
                Color c = colors[choose5wires1];
                GetComponent<Renderer>().material.color = c;
            }
            if (scenario5wires == 2 && colors.Count > 0)
            {
                if (chooseRed == 1)
                {
                    choose5wires1 = 0;
                    Color c = colors[choose5wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (i1 == 1)
                {
                    choose5wires1 = 1;
                    Color c = colors[choose5wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (i2 == 1)
                {
                    choose5wires1 = 1;
                    Color c = colors[choose5wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose5wires1 = Random.Range(1, colors.Count);
                    Color c = colors[choose5wires1];
                    GetComponent<Renderer>().material.color = c;
                }
            }
            if (scenario5wires == 3 && colors.Count > 0)
            {
                choose5wires1 = Random.Range(0, colors.Count);
                if (choose5wires1 == 2)
                {
                    while (choose5wires1 == 2)
                    {
                        choose5wires1 = Random.Range(0, colors.Count);
                    }
                }
                if (choose5wires1 == 0)
                {
                    redNum5 += 1;
                }
                if (choose5wires1 == 1)
                {
                    yellowNum5 += 1;
                }
                Color c = colors[choose5wires1];
                GetComponent<Renderer>().material.color = c;
            }
            if (scenario5wires == 4 && colors.Count > 0)
            {
                choose5wires1 = Random.Range(0, colors.Count);
                Color c = colors[choose5wires1];
                GetComponent<Renderer>().material.color = c;
                if (choose5wires1 == 2)
                {
                    blackNum5 += 1;
                }
                if (choose5wires1 == 0)
                {
                    redNum5 += 1;
                }
                if (choose5wires1 == 1)
                {
                    yellowNum5 += 1;
                }
            }
        }
        private void OnMouseDown()
        {
            if (scenario5wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario5wires == 2)
            {
                clear.GetComponent<wire5clear>().clearwire5 = true;
            }
            if (scenario5wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario5wires == 4)
            {
                clear.GetComponent<wire5clear>().clearwire5 = true;
            }
            first5wire.SetActive(false);
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            marker.Write("first wire (5 wires) cut");
            base.StartUsing(currentUsingObject);
            if (scenario5wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario5wires == 2)
            {
                clear.GetComponent<wire5clear>().clearwire5 = true;
            }
            if (scenario5wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario5wires == 4)
            {
                clear.GetComponent<wire5clear>().clearwire5 = true;
            }
            first5wire.SetActive(false);
        }
    }
}
