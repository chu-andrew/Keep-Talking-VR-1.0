using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sym2 : MonoBehaviour {
    public GameObject myObject;
    public GameObject gamesymbol2;
    RectTransform m_RectTransform;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        m_RectTransform = GetComponent<RectTransform>();
        if (myObject.GetComponent<keypadimagecontroller>().image1 == 2)
        {
            gamesymbol2.SetActive(true);

        }
        else if (myObject.GetComponent<keypadimagecontroller>().image2 == 2)
        {
            gamesymbol2.SetActive(true);
            m_RectTransform.anchoredPosition = new Vector2(200, 150);
        }
        else if (myObject.GetComponent<keypadimagecontroller>().image3 == 2)
        {
            gamesymbol2.SetActive(true);
            m_RectTransform.anchoredPosition = new Vector2(-235, -150);
        }
        else if (myObject.GetComponent<keypadimagecontroller>().image4 == 2)
        {
            gamesymbol2.SetActive(true);
            m_RectTransform.anchoredPosition = new Vector2(180, -170);
        }
        else
        {
            gamesymbol2.SetActive(false);
        }
    }
}
