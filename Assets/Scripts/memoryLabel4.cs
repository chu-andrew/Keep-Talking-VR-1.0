using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class memoryLabel4 : MonoBehaviour {

    public Text text;
    // Use this for initialization
    void Start()
    {
        text.alignment = TextAnchor.MiddleCenter;
    }

    // Update is called once per frame
    void Update()
    {
        if (!memoryLabel1.labelPicked && chooseMemoryNum.roundNum == 1 && chooseMemoryNum.listChosen)
        {
            text.text = ("" + chooseMemoryNum.labelNum1[3]);
        }
        if (!memoryLabel1.labelPicked && chooseMemoryNum.roundNum == 2 && chooseMemoryNum.listChosen)
        {
            text.text = ("" + chooseMemoryNum.labelNum2[3]);
        }
        if (!memoryLabel1.labelPicked && chooseMemoryNum.roundNum == 3 && chooseMemoryNum.listChosen)
        {
            text.text = ("" + chooseMemoryNum.labelNum3[3]);
        }
        if (!memoryLabel1.labelPicked && chooseMemoryNum.roundNum == 4 && chooseMemoryNum.listChosen)
        {
            text.text = ("" + chooseMemoryNum.labelNum4[3]);
        }
        if (!memoryLabel1.labelPicked && chooseMemoryNum.roundNum == 5 && chooseMemoryNum.listChosen)
        {
            text.text = ("" + chooseMemoryNum.labelNum5[3]);
        }
    }
}
