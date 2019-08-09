using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ventText : MonoBehaviour {
    public Text text;
    // Use this for initialization
    void Start () {
        text.text = "Calculating...";
        text.alignment = TextAnchor.MiddleCenter;
    }

    // Update is called once per frame
    void Update () {
		if(ventingwarning.chooseText == 1 && !ventingwarning.delay)
        {
            text.text = "Vent Gas?";
            text.alignment = TextAnchor.MiddleCenter;
        }
        else if (ventingwarning.chooseText == 2 && !ventingwarning.delay)
        {
            text.text = "Detonate?";
            text.alignment = TextAnchor.MiddleCenter;
        }
        else if(ventingwarning.delay)
        {
            text.text = "Calculating...";
            text.alignment = TextAnchor.MiddleCenter;
        }
    }
}
