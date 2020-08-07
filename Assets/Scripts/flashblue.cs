using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.LSL4Unity.Scripts;

namespace VRTK.Examples
{
    public class flashblue : VRTK_InteractableObject
    {
        public GameObject myObject;
        public bool isPressed = false;
        public List<Color> blueList;
        public AudioClip soundEffect;
        private LSLMarkerStream marker;
        public AudioSource source;
        private void Start()
        {
            source.clip = soundEffect;
            marker = FindObjectOfType<LSLMarkerStream>();
        }
        public void flashB()
        {
            StartCoroutine(WaitB());
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            base.StartUsing(currentUsingObject);
            marker.Write("blue simon says button pressed at ");
            source.Play();
            //transform.Translate(0, 0, -Time.deltaTime);
            if (!myObject.GetComponent<SimonSaysModule>().round1)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 3)
                {
                    myObject.GetComponent<SimonSaysModule>().round1 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round2)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 3 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 3 && myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().round2 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round3)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 3 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 3 && myObject.GetComponent<SimonSaysModule>().button1 && !myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().button2 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand3 == 3 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().round3 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round4)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 3 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 3 && myObject.GetComponent<SimonSaysModule>().button1 && !myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().button2 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand3 == 3 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2 && !myObject.GetComponent<SimonSaysModule>().button3)
                {
                    myObject.GetComponent<SimonSaysModule>().button3 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand4 == 3 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2 && myObject.GetComponent<SimonSaysModule>().button3)
                {
                    myObject.GetComponent<SimonSaysModule>().round4 = true;
                }
                else
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = false;
                    myObject.GetComponent<SimonSaysModule>().button2 = false;
                    myObject.GetComponent<SimonSaysModule>().button3 = false;
                    myObject.GetComponent<SimonSaysModule>().button4 = false;
                    mistakes.mistakeNum += 1;
                }
            }
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
            //transform.Translate(0, 0, Time.deltaTime);
        }
        void OnMouseDown()
        {
            transform.Translate(0, 0, -Time.deltaTime);
            Debug.Log("clicked");
            if (!myObject.GetComponent<SimonSaysModule>().round1)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 3)
                {
                    myObject.GetComponent<SimonSaysModule>().round1 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round2)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 3 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 3 && myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().round2 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round3)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 3 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 3 && myObject.GetComponent<SimonSaysModule>().button1 && !myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().button2 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand3 == 3 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().round3 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round4)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 3 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 3 && myObject.GetComponent<SimonSaysModule>().button1 && !myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().button2 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand3 == 3 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2 && !myObject.GetComponent<SimonSaysModule>().button3)
                {
                    myObject.GetComponent<SimonSaysModule>().button3 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand4 == 3 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2 && myObject.GetComponent<SimonSaysModule>().button3)
                {
                    myObject.GetComponent<SimonSaysModule>().round4 = true;
                }
                else
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = false;
                    myObject.GetComponent<SimonSaysModule>().button2 = false;
                    myObject.GetComponent<SimonSaysModule>().button3 = false;
                    myObject.GetComponent<SimonSaysModule>().button4 = false;
                    mistakes.mistakeNum += 1;
                }
            }
        }
        private void OnMouseUp()
        {
            transform.Translate(0, 0, Time.deltaTime);
        }
        IEnumerator WaitB()
        {
            Color z = blueList[0];
            GetComponent<MeshRenderer>().material.color = z;
            yield return new WaitForSeconds(1);
            //Debug.Log("flashB");
            Color x = blueList[1];
            GetComponent<MeshRenderer>().material.color = x;
            yield return new WaitForSeconds(0.5f);
            GetComponent<MeshRenderer>().material.color = z;
            yield return new WaitForSeconds(1);
        }
    }
}
