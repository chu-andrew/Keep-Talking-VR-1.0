using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sym7 : MonoBehaviour {
    public GameObject myObject;
    public GameObject gamesymbol1;
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
        if (myObject.GetComponent<keypadimagecontroller>().image1 == 7)
        {
            gamesymbol1.SetActive(true);

        }
        else if (myObject.GetComponent<keypadimagecontroller>().image2 == 7)
        {
            gamesymbol1.SetActive(true);
            m_RectTransform.anchoredPosition = new Vector2(200, 150);
        }
        else if (myObject.GetComponent<keypadimagecontroller>().image3 == 7)
        {
            gamesymbol1.SetActive(true);
            m_RectTransform.anchoredPosition = new Vector2(-235, -150);
        }
        else if (myObject.GetComponent<keypadimagecontroller>().image4 == 7)
        {
            gamesymbol1.SetActive(true);
            m_RectTransform.anchoredPosition = new Vector2(180, -170);
        }
        else
        {
            gamesymbol1.SetActive(false);
        }
    }
}
