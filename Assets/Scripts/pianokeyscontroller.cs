using System;
using System.Collections;
using System.Collections.Generic; //basic C# libraries. includes lists, arrays etc.
using UnityEngine; // includes unity specific functions
using VRTK.Examples; // including vrtk library

public class pianokeyscontroller : MonoBehaviour
{


    public bool wrongkey = false;
    List<int> ImagePicker = new List<int>(); 
    public int image1; 
    public int image2;
    public int image3;
    public int image4;
    private int i1; 
    private int i2;
    private int i3;
    private int i4;
    private int picklist; 
    private List<int> ImageIndex; 
    private bool[] pressed;
    public bool pianoClear = false; 
    public int numKeysPressed=0;

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

    public string[] keyOrder;

    // This will make a list of all cards

    int RandomImage()
    {
        // Return a bad card if the list wasn't made yet
        if (ImagePicker == null) return -1;

        // Return a bad card if the list is already empty
        if (ImagePicker.Count <= 0) return -1;

        // Return a random card that's left and remove it so we don't pick it again
        int PickedImageIndex = UnityEngine.Random.Range(0, ImagePicker.Count);
        int PickedImage = ImagePicker[PickedImageIndex];
        ImagePicker.RemoveAt(PickedImageIndex);
        return PickedImage;
    }
    void pickImage(int pickListInput)
    {
        switch (pickListInput)
        {// Chooses one out of six lists, and adds the image number needed for that lists
            case 1:
                ImagePicker.Add(17);
                keyOrder = new string[]{"A","B","C"}; //placeholder, change with notes
                pressed = new bool[keyOrder.Length];

                break;
            case 2:
                ImagePicker.Add(2);
                keyOrder = new string[]{"C","B","A"};
                pressed = new bool[keyOrder.Length];

                break;
        }
    }

    // Use this for initialization
    void Start()
    {
        picklist = UnityEngine.Random.Range(1, 7); //sets the integer used to pick the list to a random number between 1 and 6 
        pickImage(picklist); //picks the list with the corresponding images
        image1 = RandomImage(); // picks a random integer from the list created in the imagePicker
        image2 = RandomImage();
        image3 = RandomImage();
        image4 = RandomImage();
        ImagePicker.Clear(); // clears the list

        pickImage(picklist);
        i1 = ImagePicker.IndexOf(image1); // each image has an index, or order in which its supposed to go in, in its respective list
        i2 = ImagePicker.IndexOf(image2); // i1, i2, i3, and i4 each correspond to the keypad buttons (called keypad 1, keypad 2, etc.) respectively
        i3 = ImagePicker.IndexOf(image3);
        i4 = ImagePicker.IndexOf(image4);
        ImageIndex = new List<int> { i1, i2, i3, i4 }; //creates a new list with the image indexes
        ImageIndex.Sort(); // makes sure the list is in increasing order (first button to be pressed is index 0, second is index 1, etc)
        //Debug.Log(i1); testing purposes
    }

    // Update is called once per frame
    void Update()
    {

        if (A.GetComponent<pianoKeysA>().press){
            if("A"==keyOrder[numKeysPressed]){
                pressed[numKeysPressed] = true;
            }
            else{
                for(int i=0;i<pressed.Length;i++){
                    pressed[i] = false;
                }
                numKeysPressed =0;
                wrongkey = true;
            }
        }
        
        if (B.GetComponent<pianoKeysB>().press){
            if("B"==keyOrder[numKeysPressed]){
                pressed[numKeysPressed] = true;
            }
            else{
                for(int i=0;i<pressed.Length;i++){
                    pressed[i] = false;
                }
                numKeysPressed =0;
                wrongkey = true;
            }
        }
        
        if (C.GetComponent<pianoKeysC>().press){
            if("C"==keyOrder[numKeysPressed]){
                pressed[numKeysPressed] = true;
            }
            else{
                for(int i=0;i<pressed.Length;i++){
                    pressed[i] = false;
                }
                numKeysPressed =0;
                wrongkey = true;
            }
        }
        if (pressed[pressed.Length-1]) // if all 4 keypads are pressed in the right order, the keypad puzzle is complete
        {
            pianoClear = true;
        }
    }
}
