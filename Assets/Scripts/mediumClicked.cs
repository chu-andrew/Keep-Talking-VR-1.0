using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mediumClicked : MonoBehaviour {

    public Button mediumButton;
    public switchCamera switchC;
    public GameObject hideButton;

    // Use this for initialization
    void Start()
    {
        Button btn = mediumButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (switchCamera.difficulty != 0)
        {
            hideButton.SetActive(false);
        }
    }
    void TaskOnClick()
    {
        switchCamera.difficulty = 2;
        hideButton.SetActive(false);
    }
}
