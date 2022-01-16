using System;
using System.Collections;
using System.Collections.Generic; //basic C# libraries. includes lists, arrays etc.
using UnityEngine; // includes unity specific functions
using VRTK.Examples; // including vrtk library
using Assets.LSL4Unity.Scripts;

public class pianokeyscontroller : MonoBehaviour
{
    public int image;
    private bool[] pressed;
    public bool pianoClear = false;
    public int numKeysPressed = 0;
    public string[] keyOrder;
    public bool interrupted = false;
    private LSLMarkerStream marker;

    //these gameobjects are assigned to the keypad cubes in the game editor, in order for script to recognize if keypad is pressed or not
    public GameObject C;
    public GameObject CSharp;
    public GameObject D;
    public GameObject DSharp;
    public GameObject E;
    public GameObject F;
    public GameObject FSharp;
    public GameObject G;
    public GameObject GSharp;
    public GameObject A;
    public GameObject ASharp;
    public GameObject B;


    // This will make a list of all cards

    void pickImage(int pickListInput)
    {
        switch (pickListInput)
        {// Chooses one out of six lists, and adds the image number needed for that lists
            case 1:
                image = 1;
                keyOrder = new string[] { "ASharp", "ASharp", "ASharp", "ASharp", "FSharp", "GSharp", "ASharp", "BSharp", "ASharp" }; //placeholder, change with notes
                pressed = new bool[keyOrder.Length];
                break;
            case 2:
                image = 2;
                keyOrder = new string[] { "DSharp", "DSharp","D","D","DSharp","DSharp","D","DSharp","DSharp","D","D","DSharp" };
                pressed = new bool[keyOrder.Length];
                break;
            case 3:
                image = 3;
                keyOrder = new string[] { "G","G","C","G","G","C","G","C" };
                pressed = new bool[keyOrder.Length];
                break;
            case 4:
                image = 4;
                keyOrder = new string[] { "E","E","E","C","E","G","G" };
                pressed = new bool[keyOrder.Length];
                break;
            case 5:
                image = 5;
                keyOrder = new string[] { "G","G","G","DSharp","ASharp","G","DSharp", "ASharp","G" };
                pressed = new bool[keyOrder.Length];
                break;
        }

        for (int i = 0; i < pressed.Length; i++)
        {
            pressed[i] = false;
        }
    }

    // Use this for initialization
    void Start()
    {
        //sets the integer used to pick the list to a random number between 1 and 6 
        //picks the list with the corresponding images
        marker = FindObjectOfType<LSLMarkerStream>();
        pickImage(UnityEngine.Random.Range(1, 5));
        foreach (string x in keyOrder)
        {
            Debug.Log(x + " ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (interrupted && !pianoClear)
        {
            if (A.GetComponent<pianoKeysA>().press)
            {
                A.GetComponent<pianoKeysA>().press = false;

                if ("A" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;
                    Debug.Log("pressed a correctly");
                    marker.Write("pressed a correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    Debug.Log("pressed a incorrectly");
                    marker.Write("pressed a incorrectly");
                }
            }

            else if (ASharp.GetComponent<pianoKeysASharp>().press)
            {
                ASharp.GetComponent<pianoKeysASharp>().press = false;

                if ("ASharp" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;

                    Debug.Log("pressed asharp correctly");
                    marker.Write("pressed asharp correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;

                    Debug.Log("pressed asharp incorrectly");
                    marker.Write("pressed asharp incorrectly");
                }
            }

            else if (B.GetComponent<pianoKeysB>().press)
            {
                B.GetComponent<pianoKeysB>().press = false;

                if ("B" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;

                    Debug.Log("pressed b correctly");
                    marker.Write("pressed b correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    
                    Debug.Log("pressed b incorrectly");
                    marker.Write("pressed b incorrectly");
                }
            }

            else if (C.GetComponent<pianoKeysC>().press)
            {
                C.GetComponent<pianoKeysC>().press = false;

                if ("C" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;
                    Debug.Log("pressed c correctly");
                    marker.Write("pressed c correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    Debug.Log("pressed c incorrectly");
                    marker.Write("pressed c incorrectly");
                }
            }

            else if (CSharp.GetComponent<pianoKeysCSharp>().press)
            {
                CSharp.GetComponent<pianoKeysCSharp>().press = false;

                if ("CSharp" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;

                    Debug.Log("pressed csharp correctly");
                    marker.Write("pressed csharp correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    Debug.Log("pressed csharp incorrectly");
                    marker.Write("pressed csharp incorrectly");
                }
            }

            else if (D.GetComponent<pianoKeysD>().press)
            {
                D.GetComponent<pianoKeysD>().press = false;

                if ("D" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;

                    Debug.Log("pressed d correctly");
                    marker.Write("pressed d correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    Debug.Log("pressed d incorrectly");
                    marker.Write("pressed d incorrectly");
                }
            }

            else if (DSharp.GetComponent<pianoKeysDSharp>().press)
            {
                DSharp.GetComponent<pianoKeysDSharp>().press = false;

                if ("DSharp" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;

                    Debug.Log("pressed dsharp correctly");
                    marker.Write("pressed dsharp correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    Debug.Log("pressed dsharp incorrectly");
                    marker.Write("pressed dsharp incorrectly");
                }
            }

            else if (E.GetComponent<pianoKeysE>().press)
            {
                E.GetComponent<pianoKeysE>().press = false;

                if ("E" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;

                    Debug.Log("pressed e correctly");
                    marker.Write("pressed e correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    Debug.Log("pressed e incorrectly");
                    marker.Write("pressed e incorrectly");
                }
            }

            else if (F.GetComponent<pianoKeysF>().press)
            {
                F.GetComponent<pianoKeysF>().press = false;

                if ("F" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;

                    Debug.Log("pressed f correctly");
                    marker.Write("pressed f correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    Debug.Log("pressed f incorrectly");
                    marker.Write("pressed f incorrectly");
                }
            }

            else if (FSharp.GetComponent<pianoKeysFSharp>().press)
            {
                FSharp.GetComponent<pianoKeysFSharp>().press = false;

                if ("FSharp" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;

                    Debug.Log("pressed fsharp correctly");
                    marker.Write("pressed fsharp correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    Debug.Log("pressed fsharp incorrectly");
                    marker.Write("pressed fsharp incorrectly");
                }
            }

            else if (G.GetComponent<pianoKeysG>().press)
            {
                G.GetComponent<pianoKeysG>().press = false;

                if ("G" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;

                    Debug.Log("pressed g correctly");
                    marker.Write("pressed g correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    Debug.Log("pressed g incorrectly");
                    marker.Write("pressed g incorrectly");
                }
            }

            else if (GSharp.GetComponent<pianoKeysGSharp>().press)
            {
                GSharp.GetComponent<pianoKeysGSharp>().press = false;

                if ("GSharp" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    numKeysPressed++;

                    Debug.Log("pressed gsharp correctly");
                    marker.Write("pressed gsharp correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    mistakes.mistakeNum++;
                    Debug.Log("pressed gsharp incorrectly");
                    marker.Write("pressed gsharp incorrectly");
                }
            }

            if (pressed[pressed.Length - 1]) // if all 4 keypads are pressed in the right order, the keypad puzzle is complete
            {
                pianoClear = true;
                Debug.Log("pianoClear");
            }
            interrupted = false;
        }
    }
}
