using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

namespace VRTK.Examples
{
    public class firstwire3 : VRTK_InteractableObject
    {
        public GameObject clear;
        public int scenario3wires;
        public int blue;
        public int red;
        public GameObject first3wire;
        public int choose3wires1;
        public List<Color> colors;
        // Use this for initialization
        void Start()
        {
            scenario3wires = Random.Range(1, 5);
            red = Random.Range(1, 4);
            if (scenario3wires == 1 && colors.Count > 0)
            {
                choose3wires1 = Random.Range(1, colors.Count);
                Color c = colors[choose3wires1];

                GetComponent<Renderer>().material.color = c;
            }
            if (scenario3wires == 2 && colors.Count > 0)
            {
                red = Random.Range(1, 2);
                if (red == 1)
                {
                    choose3wires1 = 0;
                    Color c = colors[choose3wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose3wires1 = Random.Range(0, colors.Count);
                    Color c = colors[choose3wires1];

                    GetComponent<Renderer>().material.color = c;
                }
            }
            if (scenario3wires == 3 && colors.Count > 0)
            {
                blue = Random.Range(1, 2);
                if (red == 1)
                {
                    choose3wires1 = 0;
                    Color c = colors[choose3wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    if (blue == 1)
                    {
                        choose3wires1 = 4;
                        Color b = colors[choose3wires1];
                        GetComponent<Renderer>().material.color = b;
                    }
                    else
                    {
                        choose3wires1 = Random.Range(0, 3);
                        Color c = colors[choose3wires1];

                        GetComponent<Renderer>().material.color = c;
                    }
                }
            }
            if (scenario3wires == 4 && colors.Count > 0)
            {
                if (red == 1)
                {
                    choose3wires1 = 0;
                    Color c = colors[choose3wires1];

                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    if (secondwire3.choose3wires2 == 4 || thirdwire3.choose3wires3 == 4)
                    {
                        choose3wires1 = Random.Range(0, 3);
                        Color c = colors[choose3wires1];

                        GetComponent<Renderer>().material.color = c;
                    }
                    else
                    {
                        choose3wires1 = Random.Range(0, colors.Count);
                        Color c = colors[choose3wires1];

                        GetComponent<Renderer>().material.color = c;
                    }
                }
            }
        }
        private void OnMouseDown()
        {
            if (scenario3wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario3wires == 2)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario3wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario3wires == 4)
            {
                mistakes.mistakeNum += 1;
            }
            first3wire.SetActive(false);
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            if (scenario3wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario3wires == 2)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario3wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario3wires == 4)
            {
                mistakes.mistakeNum += 1;
            }
            first3wire.SetActive(false);
        }
    }
}
