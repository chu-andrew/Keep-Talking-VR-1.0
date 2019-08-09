using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

public class keypadimagecontroller : MonoBehaviour
{
    public bool wrongkeypad = false;
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
    private bool pressed1 = false;
    private bool pressed2 = false;
    private bool pressed3 = false;
    private bool pressed4 = false;
    public bool keypadClear = false;
    public GameObject keypad1;
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
        {
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
        picklist = UnityEngine.Random.Range(1,7);
        pickImage(picklist);
        image1 = RandomImage();
        image2 = RandomImage();
        image3 = RandomImage();
        image4 = RandomImage();
        ImagePicker.Clear();

        pickImage(picklist);
        i1 = ImagePicker.IndexOf(image1);
        i2 = ImagePicker.IndexOf(image2);
        i3 = ImagePicker.IndexOf(image3);
        i4 = ImagePicker.IndexOf(image4);
        ImageIndex = new List<int> { i1, i2, i3, i4 };
        ImageIndex.Sort();
        //Debug.Log(i1);
    }

    // Update is called once per frame
    void Update()
    {

        if (keypad1.GetComponent<keypad1press>().press1 && i1 == ImageIndex[0])
        {
            pressed1 = true;
        }
        else if(keypad1.GetComponent<keypad1press>().press1 && i1 == ImageIndex[1] && pressed1)
        {
            pressed2 = true;
        }
        else if (keypad1.GetComponent<keypad1press>().press1 && i1 == ImageIndex[2] && pressed2)
        {
            pressed3 = true;
        }
        else if (keypad1.GetComponent<keypad1press>().press1 && i1 == ImageIndex[3] && pressed3)
        {
            pressed4 = true;
        }
        else if(keypad1.GetComponent<keypad1press>().press1)
        {
            wrongkeypad = true;
            pressed1 = false;
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

        if (pressed1 && pressed2 && pressed3 && pressed4)
        {
            keypadClear = true;
        }
    }
}
