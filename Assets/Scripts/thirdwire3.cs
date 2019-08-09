using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK.Examples
{
    public class thirdwire3 : VRTK_InteractableObject
    {
        public GameObject myObject;
        public GameObject clear;
        public static int choose3wires3;
        public GameObject third3wire;
        public List<Color> colors;
        private bool colorChosen = false;
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            if (myObject.GetComponent<firstwire3>().scenario3wires == 1 && colors.Count > 0 && !colorChosen)
            {
                choose3wires3 = Random.Range(1, colors.Count);
                Color c = colors[choose3wires3];

                GetComponent<Renderer>().material.color = c;
            }
            if (myObject.GetComponent<firstwire3>().scenario3wires == 2 && colors.Count > 0 && !colorChosen)
            {
                choose3wires3 = 3;
                Color c = colors[choose3wires3];

                GetComponent<Renderer>().material.color = c;

            }
            if (myObject.GetComponent<firstwire3>().scenario3wires == 3 && colors.Count > 0 && !colorChosen)
            {
                if (myObject.GetComponent<firstwire3>().red == 3)
                {
                    choose3wires3 = 0;
                    Color c = colors[choose3wires3];

                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    if (secondwire3.blue2 != 1 || myObject.GetComponent<firstwire3>().blue != 1)
                    {
                        choose3wires3 = 4;
                        Color b = colors[choose3wires3];
                        GetComponent<Renderer>().material.color = b;
                    }
                    else
                    {
                        choose3wires3 = 3;
                        while (choose3wires3 == 3)
                        {
                            choose3wires3 = Random.Range(0, colors.Count);
                        }
                        Color c = colors[choose3wires3];

                        GetComponent<Renderer>().material.color = c;
                    }
                }
            }
            if (myObject.GetComponent<firstwire3>().scenario3wires == 4 && colors.Count > 0 && !colorChosen)
            {
                if (myObject.GetComponent<firstwire3>().red == 3)
                {
                    choose3wires3 = 0;
                    Color c = colors[choose3wires3];

                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    if (myObject.GetComponent<firstwire3>().choose3wires1 == 4 || secondwire3.choose3wires2 == 4)
                    {
                        choose3wires3 = Random.Range(0, 2);
                        Color c = colors[choose3wires3];

                        GetComponent<Renderer>().material.color = c;
                    }
                    else
                    {
                        choose3wires3 = 3;
                        while (choose3wires3 == 3)
                        {
                            choose3wires3 = Random.Range(0, colors.Count);
                        }
                        Color c = colors[choose3wires3];

                        GetComponent<Renderer>().material.color = c;
                    }
                }
            }
            colorChosen = true;
        }
        private void OnMouseDown()
        {
            if (myObject.GetComponent<firstwire3>().scenario3wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire3>().scenario3wires == 2)
            {
                clear.GetComponent<wire3clear>().clearwire3 = true;
            }
            if (myObject.GetComponent<firstwire3>().scenario3wires == 3 && choose3wires3 == 4)
            {
                clear.GetComponent<wire3clear>().clearwire3 = true;
            }
            else if (myObject.GetComponent<firstwire3>().scenario3wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire3>().scenario3wires == 4)
            {
                clear.GetComponent<wire3clear>().clearwire3 = true;
            }
            third3wire.SetActive(false);
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            if (myObject.GetComponent<firstwire3>().scenario3wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire3>().scenario3wires == 2)
            {
                clear.GetComponent<wire3clear>().clearwire3 = true;
            }
            if (myObject.GetComponent<firstwire3>().scenario3wires == 3 && choose3wires3 == 4)
            {
                clear.GetComponent<wire3clear>().clearwire3 = true;
            }
            else if (myObject.GetComponent<firstwire3>().scenario3wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (myObject.GetComponent<firstwire3>().scenario3wires == 4)
            {
                clear.GetComponent<wire3clear>().clearwire3 = true;
            }
            third3wire.SetActive(false);
        }
    }
}
