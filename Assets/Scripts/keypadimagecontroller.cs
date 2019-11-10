using System;
using System.Collections;
using System.Collections.Generic; //basic C# libraries. includes lists, arrays etc.
using UnityEngine; // includes unity specific functions
using VRTK.Examples; // including vrtk library

public class keypadimagecontroller : MonoBehaviour
{
    /*
     *This puzzle is where a keypad has a bunch of different symbols on it, that are randomized each time the game is run
     * There are 6 lists of symbols, and the keypad has to choose a random list every time the game is run
     * The symbols are pressed in a specific order from top to bottom of the list (list is included in the game manual)
     * If a symbol is pressed in the wrong order a mistake is made and the player has to restart the sequence
     * Each image, or symbol, has a number assigned to it.
     * Link to module: http://www.bombmanual.com/web/index.html
     */
    public bool wrongkeypad = false; // boolean for testing if the keypad pressed was the wrong keypad
    List<int> ImagePicker = new List<int>(); // List picks the symbol that is used for the image
    public int image1; // image number (what it's called in the game editor)
    public int image2;
    public int image3;
    public int image4;
    private int i1; //image order number (in each respective list)
    private int i2;
    private int i3;
    private int i4;
    private int picklist; // int for picking which image is which
    private List<int> ImageIndex; // list for ordering images
    private bool pressed1 = false; // boolean for checking whether previous buttons were pressed or not
    private bool pressed2 = false;
    private bool pressed3 = false;
    private bool pressed4 = false;
    public bool keypadClear = false; //turns true when keypad puzzle is complete
    public GameObject keypad1; //these gameobjects are assigned to the keypad cubes in the game editor, in order for script to recognize if keypad is pressed or not
    public GameObject keypad2;
    public GameObject keypad3;
    public GameObject keypad4;
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
                ImagePicker.Add(5);
                ImagePicker.Add(20);
                ImagePicker.Add(16);
                ImagePicker.Add(6);
                ImagePicker.Add(19);
                ImagePicker.Add(14);

                break;
            case 2:
                ImagePicker.Add(2);
                ImagePicker.Add(17);
                ImagePicker.Add(14);
                ImagePicker.Add(10);
                ImagePicker.Add(26);
                ImagePicker.Add(19);
                ImagePicker.Add(24);

                break;
            case 3:
                ImagePicker.Add(23);
                ImagePicker.Add(4);
                ImagePicker.Add(10);
                ImagePicker.Add(9);
                ImagePicker.Add(11);
                ImagePicker.Add(20);
                ImagePicker.Add(26);

                break;
            case 4:
                ImagePicker.Add(1);
                ImagePicker.Add(25);
                ImagePicker.Add(7);
                ImagePicker.Add(6);
                ImagePicker.Add(9);
                ImagePicker.Add(24);
                ImagePicker.Add(22);

                break;
            case 5:
                ImagePicker.Add(15);
                ImagePicker.Add(22);
                ImagePicker.Add(7);
                ImagePicker.Add(13);
                ImagePicker.Add(25);
                ImagePicker.Add(3);
                ImagePicker.Add(27);

                break;
            case 6:
                ImagePicker.Add(1);
                ImagePicker.Add(2);
                ImagePicker.Add(12);
                ImagePicker.Add(21);
                ImagePicker.Add(15);
                ImagePicker.Add(8);
                ImagePicker.Add(18);

                break;
        }
    }

    // Use this for initialization
    void Start()
    {
        picklist = UnityEngine.Random.Range(1,7); //sets the integer used to pick the list to a random number between 1 and 6 
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
        //this if-else if statement is repeated for all 4 keypad buttons
        if (keypad1.GetComponent<keypad1press>().press1 && i1 == ImageIndex[0]) // if keypad1 is pressed and its supposed to be the first one pressed
        {
            pressed1 = true;
        }
        else if(keypad1.GetComponent<keypad1press>().press1 && i1 == ImageIndex[1] && pressed1) // if keypad1 is pressed and its supposed to be the second one pressed
        {
            pressed2 = true;
        }
        else if (keypad1.GetComponent<keypad1press>().press1 && i1 == ImageIndex[2] && pressed2)// if keypad1 is pressed and its supposed to be the third one pressed
        {
            pressed3 = true;
        }
        else if (keypad1.GetComponent<keypad1press>().press1 && i1 == ImageIndex[3] && pressed3)// if keypad1 is pressed and its supposed to be the fourth one pressed
        {
            pressed4 = true;
        }
        else if(keypad1.GetComponent<keypad1press>().press1) // if keypad1 was pressed in the wrong order
        {
            wrongkeypad = true;
            pressed1 = false; //restarts the sequence
            pressed2 = false;
            pressed3 = false;
            pressed4 = false;
        }

        if (keypad2.GetComponent<keypad2press>().press2 && i2 == ImageIndex[0])
        {
            pressed1 = true;
        }
        else if (keypad2.GetComponent<keypad2press>().press2 && i2 == ImageIndex[1] && pressed1)
        {
            pressed2 = true;
        }
        else if (keypad2.GetComponent<keypad2press>().press2 && i2 == ImageIndex[2] && pressed2)
        {
            pressed3 = true;
        }
        else if (keypad2.GetComponent<keypad2press>().press2 && i2 == ImageIndex[3] && pressed3)
        {
            pressed4 = true;
        }
        else if (keypad2.GetComponent<keypad2press>().press2)
        {
            wrongkeypad = true;
            pressed1 = false;
            pressed2 = false;
            pressed3 = false;
            pressed4 = false;
        }

        if (keypad3.GetComponent<keypad3press>().press3 && i3 == ImageIndex[0])
        {
            pressed1 = true;
        }
        else if (keypad3.GetComponent<keypad3press>().press3 && i3 == ImageIndex[1] && pressed1)
        {
            pressed2 = true;
        }
        else if (keypad3.GetComponent<keypad3press>().press3 && i3 == ImageIndex[2] && pressed2)
        {
            pressed3 = true;
        }
        else if (keypad3.GetComponent<keypad3press>().press3 && i3 == ImageIndex[3] && pressed3)
        {
            pressed4 = true;
        }
        else if (keypad3.GetComponent<keypad3press>().press3)
        {
            wrongkeypad = true;
            pressed1 = false;
            pressed2 = false;
            pressed3 = false;
            pressed4 = false;
        }

        if (keypad4.GetComponent<keypad4press>().press4 && i4 == ImageIndex[0])
        {
            pressed1 = true;
        }
        else if (keypad4.GetComponent<keypad4press>().press4 && i4 == ImageIndex[1] && pressed1)
        {
            pressed2 = true;
        }
        else if (keypad4.GetComponent<keypad4press>().press4 && i4 == ImageIndex[2] && pressed2)
        {
            pressed3 = true;
        }
        else if (keypad4.GetComponent<keypad4press>().press4 && i4 == ImageIndex[3] && pressed3)
        {
            pressed4 = true;
        }
        else if (keypad4.GetComponent<keypad4press>().press4)
        {
            wrongkeypad = true;
            pressed1 = false;
            pressed2 = false;
            pressed3 = false;
            pressed4 = false;
        }

        if (pressed1 && pressed2 && pressed3 && pressed4) // if all 4 keypads are pressed in the right order, the keypad puzzle is complete
        {
            keypadClear = true;
        }
    }
}
