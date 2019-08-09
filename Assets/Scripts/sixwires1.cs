using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK.Examples
{
    public class sixwires1 : VRTK_InteractableObject
    {
        public int scenario6wires;
        public GameObject wire6;
        public int choose6wires1;
        public int chooseYellow6;
        public int z1;
        public int z2;
        public int redNum6 = 0;
        public int yellowNum6 = 0;
        public int whiteNum6 = 0;
        public List<Color> colors;
        // Use this for initialization
        void Start()
        {
            z1 = Random.Range(1, 7);
            z2 = Random.Range(1, 7);
            if (z1 == z2)
            {
                while (z1 == z2)
                {
                    z2 = Random.Range(1, 7);
                }
            }
            chooseYellow6 = Random.Range(1, 7);
            if (chooseYellow6 == z1 || chooseYellow6 == z2)
            {
                while (chooseYellow6 == z1 || chooseYellow6 == z2)
                {
                    chooseYellow6 = Random.Range(1, 7);
                }
            }
            scenario6wires = Random.Range(1, 5);
            if (scenario6wires == 1 && colors.Count > 0)
            {
                choose6wires1 = Random.Range(0, colors.Count);
                if (choose6wires1 == 1)
                {
                    while (choose6wires1 == 1)
                    {
                        choose6wires1 = Random.Range(0, colors.Count);
                    }
                }
                Color c = colors[choose6wires1];
                GetComponent<Renderer>().material.color = c;
            }
            if (scenario6wires == 2 && colors.Count > 0)
            {
                if (chooseYellow6 == 1)
                {
                    choose6wires1 = 1;
                    Color c = colors[choose6wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (z1 == 1)
                {
                    choose6wires1 = 3;
                    Color c = colors[choose6wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else if (z2 == 1)
                {
                    choose6wires1 = 3;
                    Color c = colors[choose6wires1];
                    GetComponent<Renderer>().material.color = c;
                }
                else
                {
                    choose6wires1 = Random.Range(0, colors.Count);
                    if (choose6wires1 == 1)
                    {
                        while (choose6wires1 == 1)
                        {
                            choose6wires1 = Random.Range(0, colors.Count);
                        }
                    }
                    Color c = colors[choose6wires1];
                    GetComponent<Renderer>().material.color = c;
                }
            }
            if (scenario6wires == 3 && colors.Count > 0)
            {
                choose6wires1 = Random.Range(1, colors.Count);
                Color c = colors[choose6wires1];
                GetComponent<Renderer>().material.color = c;
                if (choose6wires1 == 1)
                {
                    yellowNum6 += 1;
                }
                if (choose6wires1 == 3)
                {
                    whiteNum6 += 1;
                }
            }
            if (scenario6wires == 4 && colors.Count > 0)
            {
                choose6wires1 = Random.Range(0, colors.Count);
                Color c = colors[choose6wires1];
                GetComponent<Renderer>().material.color = c;
                if (choose6wires1 == 0)
                {
                    redNum6 += 1;
                }
                if (choose6wires1 == 1)
                {
                    yellowNum6 += 1;
                }
                if (choose6wires1 == 3)
                {
                    whiteNum6 += 1;
                }
            }
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            if (scenario6wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario6wires == 2)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario6wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario6wires == 4)
            {
                mistakes.mistakeNum += 1;
            }
            wire6.SetActive(false);
        }
        private void OnMouseDown()
        {
            if (scenario6wires == 1)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario6wires == 2)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario6wires == 3)
            {
                mistakes.mistakeNum += 1;
            }
            if (scenario6wires == 4)
            {
                mistakes.mistakeNum += 1;
            }
            wire6.SetActive(false);
        }
    }
}
