using System.Collections;
using System.Collections.Generic;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    using UnityEngine;
    public class randomtextures : VRTK_InteractableObject
    {
        public AudioClip soundEffect;
        public AudioSource source;
        public List<Color> colors;
        private int choose;
        private string color;
        private LSLMarkerStream marker;
        private bool blue;
        private bool red;
        private bool yellow;
        private bool white;
        private bool isPressed;
        public bool clear = false;
        private bool wrong;
        // Use this for initialization
        static bool isDigitPresent(int x, int d)
        {
            // Breal loop if d is present as digit 
            while (x > 0)
            {
                if (x % 10 == d)
                    break;

                x = x / 10;
            }

            // If loop broke 
            return (x > 0);
        }

        void Start()
        {
            marker = FindObjectOfType<LSLMarkerStream>();
            source.clip = soundEffect;
            if (colors.Count > 0)
            {
                choose = Random.Range(0, colors.Count);
                Color c = colors[choose];

                GetComponent<Renderer>().material.color = c;
            }
            switch (choose)
            {
                case 0:
                    blue = true;
                    color = "blue";
                    break;
                case 1:
                    red = true;
                    color = "red";
                    break;
                case 2:
                    white = true;
                    color = "white";
                    break;
                case 3:
                    yellow = true;
                    color = "yellow";
                    break;
                default:
                    break;
            }

        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            marker.Write(color +" button pressed at ");
            source.Play();
            transform.Translate(0, 0, -Time.deltaTime);
            isPressed = true;
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
            transform.Translate(0, 0, Time.deltaTime);
            isPressed = false;
            if (wrong)
            {
                mistakes.mistakeNum += 1;
                wrong = false;
            }
        }
        private void OnMouseDown()
        {
            transform.Translate(0, 0, -Time.deltaTime);
            isPressed = true;
        }
        private void OnMouseUp()
        {
            transform.Translate(0, 0, Time.deltaTime);
            isPressed = false;
            if (wrong)
            {
                mistakes.mistakeNum += 1;
                wrong = false;
            }
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
            if (blue && isPressed && isDigitPresent(countdown.mainTimer, 4) && !clear)
            {
                clear = true;
            }
            else if (red && isPressed && !clear && isDigitPresent(countdown.mainTimer, 5))
            {
                clear = true;
            }
            else if (white && isPressed && isDigitPresent(countdown.mainTimer, 1) && !clear)
            {
                clear = true;
            }
            else if (yellow && isPressed && isDigitPresent(countdown.mainTimer, 3) && !clear)
            {
                clear = true;
            }
            else if (isPressed && !clear && !wrong)
            {
                wrong = true;
            }
        }
    }
}
