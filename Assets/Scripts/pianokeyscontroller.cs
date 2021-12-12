using System;
using System.Collections;
using System.Collections.Generic; //basic C# libraries. includes lists, arrays etc.
using UnityEngine; // includes unity specific functions
using VRTK.Examples; // including vrtk library

public class pianokeyscontroller : MonoBehaviour
{
    public int image;

    public bool wrongkey = false;
    private int picklist;
    private bool[] pressed;
    public bool pianoClear = false;
    public int numKeysPressed = 0;
    public string[] keyOrder;
    public bool interrupted = false;

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
                keyOrder = new string[] { "B", "B", "C" }; //placeholder, change with notes
                pressed = new bool[keyOrder.Length];
                break;
            case 2:
                image = 2;
                keyOrder = new string[] { "B", "B", "C" };
                pressed = new bool[keyOrder.Length];
                break;
            case 3:
                image = 3;
                keyOrder = new string[] { "B", "B", "C" };
                pressed = new bool[keyOrder.Length];
                break;
            case 4:
                image = 4;
                keyOrder = new string[] { "B", "B", "C" };
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
        picklist = UnityEngine.Random.Range(1, 5); //sets the integer used to pick the list to a random number between 1 and 6 
        pickImage(picklist); //picks the list with the corresponding images
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
            /*
            foreach (bool y in pressed) {
                Debug.Log(y);
            }
            */
            if (A.GetComponent<pianoKeysA>().press)
            {
                if ("A" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    A.GetComponent<pianoKeysA>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed a correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed a incorrectly");
                }
            }

            else if (ASharp.GetComponent<pianoKeysASharp>().press)
            {
                if ("ASharp" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    ASharp.GetComponent<pianoKeysASharp>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed asharp correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed asharp incorrectly");
                }
            }

            else if (B.GetComponent<pianoKeysB>().press)
            {
                if ("B" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    B.GetComponent<pianoKeysB>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed b correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed b incorrectly");
                }
            }

            else if (C.GetComponent<pianoKeysC>().press)
            {
                if ("C" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    C.GetComponent<pianoKeysC>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed c correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed c incorrectly");
                }
            }

            else if (CSharp.GetComponent<pianoKeysCSharp>().press)
            {
                if ("CSharp" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    CSharp.GetComponent<pianoKeysCSharp>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed csharp correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed csharp incorrectly");
                }
            }

            else if (D.GetComponent<pianoKeysD>().press)
            {
                if ("D" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    D.GetComponent<pianoKeysD>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed d correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed d incorrectly");
                }
            }

            else if (DSharp.GetComponent<pianoKeysDSharp>().press)
            {
                if ("DSharp" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    DSharp.GetComponent<pianoKeysDSharp>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed dsharp correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed dsharp incorrectly");
                }
            }

            else if (E.GetComponent<pianoKeysE>().press)
            {
                if ("E" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    E.GetComponent<pianoKeysE>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed e correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed e incorrectly");
                }
            }

            else if (F.GetComponent<pianoKeysF>().press)
            {
                if ("F" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    F.GetComponent<pianoKeysF>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed f correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed f incorrectly");
                }
            }

            else if (FSharp.GetComponent<pianoKeysFSharp>().press)
            {
                if ("FSharp" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    FSharp.GetComponent<pianoKeysFSharp>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed fsharp correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed fsharp incorrectly");
                }
            }

            else if (G.GetComponent<pianoKeysG>().press)
            {
                if ("G" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    G.GetComponent<pianoKeysG>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed g correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed g incorrectly");
                }
            }

            else if (GSharp.GetComponent<pianoKeysGSharp>().press)
            {
                if ("GSharp" == keyOrder[numKeysPressed])
                {
                    pressed[numKeysPressed] = true;
                    GSharp.GetComponent<pianoKeysGSharp>().press = false;
                    numKeysPressed++;

                    Debug.Log("pressed gsharp correctly");
                }
                else
                {
                    for (int i = 0; i < pressed.Length; i++)
                    {
                        pressed[i] = false;
                    }
                    numKeysPressed = 0;
                    wrongkey = true;
                    Debug.Log("pressed gsharp incorrectly");
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
