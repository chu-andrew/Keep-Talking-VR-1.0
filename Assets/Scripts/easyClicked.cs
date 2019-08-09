using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class easyClicked : MonoBehaviour {

    public Button easyButton;
    public switchCamera switchC;
    public GameObject hideButton;

    // Use this for initialization
    void Start()
    {
        Button btn = easyButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if(switchCamera.difficulty != 0)
        {
            hideButton.SetActive(false);
        }
    }
    void TaskOnClick()
    {
        switchCamera.difficulty = 1;
        hideButton.SetActive(false);

    }
}
