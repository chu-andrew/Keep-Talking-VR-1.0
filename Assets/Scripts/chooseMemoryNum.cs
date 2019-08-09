using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chooseMemoryNum : MonoBehaviour {
    public Text text;
    public static int displayNum;
    public static bool listChosen = false;
    public static int roundNum = 1;
    public static bool roundPicked = true;
    public static List<int> labelNum1;
    public static List<int> labelNum2;
    public static List<int> labelNum3;
    public static List<int> labelNum4;
    public static List<int> labelNum5;

    // Use this for initialization
    void randomizeList(List<int> list)
    {
        int i1 = Random.Range(1, 5);
        int i2 = Random.Range(1, 5);
        while (i1 == i2)
        {
            i2 = Random.Range(1, 5);
        }
        int i3 = Random.Range(1, 5);
        while (i1 == i3 || i2 == i3)
        {
            i3 = Random.Range(1, 5);
        }
        int i4 = Random.Range(1, 5);
        while (i4 == i1 || i4 == i2 || i4 == i3)
        {
            i4 = Random.Range(1, 5);
        }
        list = new List<int> { i1, i2, i3, i4 };
    }

    void Start () {
        int i1 = Random.Range(1, 5);
        int i2 = Random.Range(1, 5);
        while (i1 == i2)
        {
            i2 = Random.Range(1, 5);
        }
        int i3 = Random.Range(1, 5);
        while (i1 == i3 || i2 == i3)
        {
            i3 = Random.Range(1, 5);
        }
        int i4 = Random.Range(1, 5);
        while (i4 == i1 || i4 == i2 || i4 == i3)
        {
            i4 = Random.Range(1, 5);
        }
        labelNum1 = new List<int> { i1, i2, i3, i4 };
        i1 = Random.Range(1, 5);
        i2 = Random.Range(1, 5);
        while (i1 == i2)
        {
            i2 = Random.Range(1, 5);
        }
        i3 = Random.Range(1, 5);
        while (i1 == i3 || i2 == i3)
        {
            i3 = Random.Range(1, 5);
        }
        i4 = Random.Range(1, 5);
        while (i4 == i1 || i4 == i2 || i4 == i3)
        {
            i4 = Random.Range(1, 5);
        }
        labelNum2 = new List<int> { i1, i2, i3, i4 };
        i1 = Random.Range(1, 5);
        i2 = Random.Range(1, 5);
        while (i1 == i2)
        {
            i2 = Random.Range(1, 5);
        }
        i3 = Random.Range(1, 5);
        while (i1 == i3 || i2 == i3)
        {
            i3 = Random.Range(1, 5);
        }
        i4 = Random.Range(1, 5);
        while (i4 == i1 || i4 == i2 || i4 == i3)
        {
            i4 = Random.Range(1, 5);
        }
        labelNum3 = new List<int> { i1, i2, i3, i4 };
        i1 = Random.Range(1, 5);
        i2 = Random.Range(1, 5);
        while (i1 == i2)
        {
            i2 = Random.Range(1, 5);
        }
        i3 = Random.Range(1, 5);
        while (i1 == i3 || i2 == i3)
        {
            i3 = Random.Range(1, 5);
        }
        i4 = Random.Range(1, 5);
        while (i4 == i1 || i4 == i2 || i4 == i3)
        {
            i4 = Random.Range(1, 5);
        }
        labelNum4 = new List<int> { i1, i2, i3, i4 };
        i1 = Random.Range(1, 5);
        i2 = Random.Range(1, 5);
        while (i1 == i2)
        {
            i2 = Random.Range(1, 5);
        }
        i3 = Random.Range(1, 5);
        while (i1 == i3 || i2 == i3)
        {
            i3 = Random.Range(1, 5);
        }
        i4 = Random.Range(1, 5);
        while (i4 == i1 || i4 == i2 || i4 == i3)
        {
            i4 = Random.Range(1, 5);
        }
        labelNum5 = new List<int> { i1, i2, i3, i4 };
        roundNum = 1;
        text.fontSize = 20;
        displayNum = Random.Range(1, 5);
        text.alignment = TextAnchor.MiddleCenter;
        text.text = ("" + displayNum);
        listChosen = true;
    }

    // Update is called once per frame
    void Update () {
        if (roundNum == 1 && !roundPicked)
        {
            displayNum = Random.Range(1, 5);
            text.text = displayNum.ToString();
            roundPicked = true;
        }
        if (roundNum == 2 && !roundPicked)
        {
            displayNum = Random.Range(1, 5);
            text.text = displayNum.ToString();
            roundPicked = true;
        }
        if (roundNum == 3 && !roundPicked)
        {
            displayNum = Random.Range(1, 5);
            text.text = displayNum.ToString();
            roundPicked = true;
        }
        if (roundNum == 4 && !roundPicked)
        {
            displayNum = Random.Range(1, 5);
            text.text = displayNum.ToString();
            roundPicked = true;
        }
        if (roundNum == 5 && !roundPicked)
        {
            displayNum = Random.Range(1, 5);
            text.text = displayNum.ToString();
            roundPicked = true;
        }
    }
}
