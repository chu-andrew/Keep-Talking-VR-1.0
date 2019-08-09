using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hardClicked : MonoBehaviour {

    public Button hardButton;
    public GameObject hideButton;
    public switchCamera switchC;

    // Use this for initialization
    void Start () {
        Button btn = hardButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update () {
        if (switchCamera.difficulty != 0)
        {
            hideButton.SetActive(false);
        }
    }
    void TaskOnClick()
    {
        switchCamera.difficulty = 3;
        hideButton.SetActive(false);
    }
}
