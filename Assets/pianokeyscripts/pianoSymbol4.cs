using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// copied this class from sym1.cs in symbolscripts
public class pianoSymbol4 : MonoBehaviour
{
    public GameObject myObject;
    public GameObject pianoImage4;
    RectTransform m_RectTransform;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        m_RectTransform = GetComponent<RectTransform>();
        //Initiate the x and y positions
        if (myObject.GetComponent<pianokeyscontroller>().image == 4)
        {
            pianoImage4.SetActive(true);
        }
        else
        {
            pianoImage4.SetActive(false);
        }
    }
}
