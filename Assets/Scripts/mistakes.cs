using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mistakes : MonoBehaviour {
    [SerializeField] private Text mistakeText;
    // Use this for initialization
    private bool playing = true;
    public static float mistakeNum;
    public AudioClip beep;
    public AudioSource beepSource;
    private bool oneMistakeMade = false;
    private bool twoMistakeMade = false;
    private bool threeMistakeMade = false;

    void Start () {
        beepSource.clip = beep;
        mistakeNum = 0;
        mistakeText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        /*
        int digit = 1;
        bool result = countdown.mainTimer.ToString().Contains(digit.ToString());
        if (result)
        {
            mistakeNum += 1;
        }
        */
		if(mistakeNum == 1 && !oneMistakeMade)
        {
            mistakeText.text = "X";
            oneMistakeMade = true;
            playing = false;
        }
        else if(mistakeNum == 2 && !twoMistakeMade)
        {
            mistakeText.text = "X X";
            twoMistakeMade = true;
            playing = false;
        }
        else if(mistakeNum >= 3 && !threeMistakeMade)
        {
            mistakeText.text = "X X X";
            threeMistakeMade = true;
            playing = false;
        }
        if (!beepSource.isPlaying && !playing)
        {
            beepSource.Play();
            playing = true;
        }
    }
}
