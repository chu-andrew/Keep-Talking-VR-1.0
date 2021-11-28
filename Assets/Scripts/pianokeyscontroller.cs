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
    public int numKeysPressed=0;
    public string[] keyOrder;


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
                keyOrder = new string[] { "B", "B", "B" }; //placeholder, change with notes
                pressed = new bool[keyOrder.Length];
                break;
            case 2:
                image = 2;
                keyOrder = new string[] { "B", "B", "B" };
                pressed = new bool[keyOrder.Length];
                break;
            case 3:
                image = 3;
                keyOrder = new string[] { "B", "B" ,"B"};
                pressed = new bool[keyOrder.Length];
                break;
            case 4:
                image = 4;
                keyOrder = new string[] { "B", "B", "B" };
                pressed = new bool[keyOrder.Length];
                break;
        }
        for (int i = 0; i < pressed.Length; i++) {
            pressed[i] = false;
        }
    }

    // Use this for initialization
    void Start()
    {
        picklist = UnityEngine.Random.Range(1, 5); //sets the integer used to pick the list to a random number between 1 and 6 
        pickImage(picklist); //picks the list with the corresponding images
        foreach (string x in keyOrder) {
            Debug.Log(x + " ");
        }
    }

    // Update is called once per frame
    void Update()
    {   
        /*
        foreach (bool y in pressed) {
            Debug.Log(y);
        }
        */
        if (A.GetComponent<pianoKeysA>().press){
            if("A"==keyOrder[numKeysPressed]){
                pressed[numKeysPressed] = true;
                numKeysPressed++;
            }
            else{
                for(int i=0;i<pressed.Length;i++){
                    pressed[i] = false;
                }
                numKeysPressed =0;
                wrongkey = true;
            }
        }
        
        else if (B.GetComponent<pianoKeysB>().press){
            if("B"==keyOrder[numKeysPressed]){
                pressed[numKeysPressed] = true;
                numKeysPressed++;

                Debug.Log("pressed b correctly");
            }
            else
            {
                for(int i=0;i<pressed.Length;i++){
                    pressed[i] = false;
                }
                numKeysPressed =0;
                wrongkey = true;
                Debug.Log("pressed b incorrectly");
            }
            Debug.Log("pressed b");
        }
        
        else if (C.GetComponent<pianoKeysC>().press){
            if("C"==keyOrder[numKeysPressed]){
                pressed[numKeysPressed] = true;
                numKeysPressed++;

            }
            else
            {
                for(int i=0;i<pressed.Length;i++){
                    pressed[i] = false;
                }
                numKeysPressed =0;
                wrongkey = true;
            }
        }

        else if (D.GetComponent<pianoKeysD>().press)
        {
            if ("D" == keyOrder[numKeysPressed])
            {
                pressed[numKeysPressed] = true;
                numKeysPressed++;

            }
            else
            {
                for (int i = 0; i < pressed.Length; i++)
                {
                    pressed[i] = false;
                }
                numKeysPressed = 0;
                wrongkey = true;
            }
        }

        if (pressed[pressed.Length-1]) // if all 4 keypads are pressed in the right order, the keypad puzzle is complete
        {
            pianoClear = true;
            Debug.Log("pianoClear");
        }
    }
}
