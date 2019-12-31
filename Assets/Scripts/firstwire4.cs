using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class firstwire4 : VRTK_InteractableObject
    {
        public GameObject clear;
        public int scenario4wires;
        public int blue;
        public int yellowNum = 0;
        public int blueNum = 0;
        public int redNum = 0;
        public int randomRed1;
        public int randomYellow1;
        private LSLMarkerStream marker;
        public int randomYellow2;
        public int randomRed2;
        public GameObject wire;
        public int choose4wires1;
        public List<Color> colors;
        // Use this for initialization
        void Start()
        {
            marker = FindObjectOfType<LSLMarkerStream>();
            randomRed1 = Random.Range(1, 5);
            randomRed2 = Random.Range(1, 5);
            if (randomRed1 == randomRed2)
            {
                while (randomRed1 == randomRed2)
                {
                    randomRed2 = Random.Range(1, 5);
                }
            }
            randomYellow1 = Random.Range(1, 5);
            randomYellow2 = Random.Range(1, 5);
            if (randomYellow1 == randomYellow2)
            {
                while (randomYellow1 == randomYellow2)
                {
                    randomYellow2 = Random.Range(1, 5);
                }
            }

            scenario4wires = Random.Range(1, 6);
            blue = Random.Range(1, 5);
            if (scenario4wires == 1 && colors.Count > 0)
            {
                if (randomRed1 == 1 || randomRed2 == 1)
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
            }
            if (scenario4wires == 2 && colors.Count > 0)
            {
                choose4wires1 = Random.Range(1, colors.Count);
                Color c = colors[choose4wires1];

                GetComponent<Renderer>().material.color = c;
            }
            if (scenario4wires == 3 && colors.Count > 0)
            {
                if (blue == 1)
                {
                    choose4wires1 = 4;
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                else if (redNum >= 1)
                {
                    choose4wires1 = Random.Range(1, 4);
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
                    yellowNum = yellowNum + 1;
                }
                if (choose4wires1 == 4)
                {
                    blueNum = blueNum + 1;
                }
                if (choose4wires1 == 0)
                {
                    redNum = redNum + 1;
                }
            }
            if (scenario4wires == 4 && colors.Count > 0)
            {
                if (randomYellow1 == 1 || randomYellow2 == 1)
                {
                    choose4wires1 = 1;
                    Color c = colors[choose4wires1];

                    GetComponent<Renderer>().material.color = c;

                }
                else if (redNum >= 1)
                {
                    choose4wires1 = Random.Range(1, 4);
                    Color c = colors[choose4wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (redNum == 0 && (randomYellow1 == 4 || randomYellow2 == 4))
                {
                    choose4wires1 = 0;
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
                    yellowNum = yellowNum + 1;
                }
                if (choose4wires1 == 4)
                {
                    blueNum = blueNum + 1;
                }
                if (choose4wires1 == 0)
                {
                    redNum = redNum + 1;
                }
            }
            if (scenario4wires == 5 && colors.Count > 0)
            {
                if (redNum >= 1)
                {
                    if (yellowNum >= 1)
                    {
                        choose4wires1 = Random.Range(2, 4);
                        Color c = colors[choose4wires1];

                        GetComponent<Renderer>().material.color = c;
                    }
                    else
                    {
                        choose4wires1 = Random.Range(1, 4);
                        Color c = colors[choose4wires1];

                        GetComponent<Renderer>().material.color = c;
                    }
                }
                else if (yellowNum >= 1)
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
                    yellowNum = yellowNum + 1;
                }
                if (choose4wires1 == 4)
                {
                    blueNum = blueNum + 1;
                }
                if (choose4wires1 == 0)
                {
                    redNum = redNum + 1;
                }
            }
        }
        private void OnMouseDown()
        {
            if (scenario4wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario4wires == 2)
            {
                clear.GetComponent<wire4clear>().clearwire4 = true;
            }
            if (scenario4wires == 3)
            {
                clear.GetComponent<wire4clear>().clearwire4 = true;
            }
            if (scenario4wires == 4)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario4wires == 5)
            {
                mistakes.mistakeNum += 1;
            }
            wire.SetActive(false);
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            marker.Write("first wire (4 wires)" + " cut at ", Time.time);
            if (scenario4wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario4wires == 2)
            {
                clear.GetComponent<wire4clear>().clearwire4 = true;
            }
            if (scenario4wires == 3)
            {
                clear.GetComponent<wire4clear>().clearwire4 = true;
            }
            if (scenario4wires == 4)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario4wires == 5)
            {
                mistakes.mistakeNum += 1;
            }
            wire.SetActive(false);
        }
    }
}
