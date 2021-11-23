using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// copied this class from sym1.cs in symbolscripts
public class pianoSymbol1 : MonoBehaviour
{
    public GameObject myObject;
    public GameObject pianoImage1;
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
        if (myObject.GetComponent<pianokeyscontroller>().image == 1)
        {
            pianoImage1.SetActive(true);
        }
        else
        {
            pianoImage1.SetActive(false);
        }
    }
}
