using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

public class morseCodeController : MonoBehaviour {
    public GameObject morseCodeText;
    public GameObject morseCodeFlash;
    public bool correct;
    Coroutine MyCoroutine;
    private int solution;
    // Use this for initialization
    void Start () {
        correct = false;
        solution = Random.Range(1, 17);
        switch (solution)
        {
            case 1:
                MyCoroutine = StartCoroutine(shell());
                break;
            case 2:
                MyCoroutine = StartCoroutine(halls());
                break;
            case 3:
                MyCoroutine = StartCoroutine(slick());
                break;
            case 4:
                MyCoroutine = StartCoroutine(trick());
                break;
            case 5:
                MyCoroutine = StartCoroutine(boxes());
                break;
            case 6:
                MyCoroutine = StartCoroutine(leaks());
                break;
            case 7:
                MyCoroutine = StartCoroutine(strobe());
                break;
            case 8:
                MyCoroutine = StartCoroutine(bistro());
                break;
            case 9:
                MyCoroutine = StartCoroutine(flick());
                break;
            case 10:
                MyCoroutine = StartCoroutine(bombs());
                break;
            case 11:
                MyCoroutine = StartCoroutine(breakW());
                break;
            case 12:
                MyCoroutine = StartCoroutine(brick());
                break;
            case 13:
                MyCoroutine = StartCoroutine(steak());
                break;
            case 14:
                MyCoroutine = StartCoroutine(sting());
                break;
            case 15:
                MyCoroutine = StartCoroutine(vector());
                break;
            case 16:
                MyCoroutine = StartCoroutine(beats());
                break;
        }
    }

    public void changeLeft()
    {
        if(morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.600"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.595";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.595"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.592";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.592"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.582";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.582"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.575";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.575"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.572";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.572"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.565";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.565"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.555";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.555"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.552";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.552"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.545";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.545"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.542";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.542"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.535";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.535"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.532";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.532"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.522";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.522"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.515";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.515"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.505";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.505"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.500";
        }
    }

    public void changeRight()
    {
        if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.500"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.505";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.505"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.515";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.515"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.522";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.522"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.532";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.532"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.535";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.535"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.542";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.542"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.545";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.545"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.552";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.552"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.555";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.555"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.565";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.565"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.572";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.572"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.575";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.575"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.582";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.582"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.592";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.592"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.595";
        }
        else if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.595"))
        {
            morseCodeText.GetComponent<morseCodeTextScript>().mhzText = "3.600";
        }
    }

    // Update is called once per frame
    void Update () {
    }
    
    public void checkSolution()
    {
        if (!correct)
        {
            switch (solution)
            {
                case 1:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.505"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    } else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 2:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.515"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 3:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.522"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 4:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.532"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 5:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.535"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 6:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.542"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 7:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.545"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 8:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.552"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 9:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.555"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 10:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.565"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 11:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.572"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 12:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.575"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 13:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.582"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 14:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.592"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 15:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.595"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
                case 16:
                    if (morseCodeText.GetComponent<morseCodeTextScript>().mhzText.Equals("3.600"))
                    {
                        StopCoroutine(MyCoroutine);
                        correct = true;
                    }
                    else
                    {
                        mistakes.mistakeNum += 1;
                    }
                    break;
            }
        }
    }

    IEnumerator shell()
    {
        while(!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator halls()
    {
        while(!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator slick()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator trick()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(4);
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator boxes()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator leaks()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator strobe()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator bistro()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator flick()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator bombs()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator breakW()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator brick()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator steak()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator sting()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(2);
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
            yield return new WaitForSeconds(4);
        }
    }
    IEnumerator vector()
    {
        while (!correct)
        {
            yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return new WaitForSeconds(2);
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return new WaitForSeconds(2);
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return new WaitForSeconds(2);
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return new WaitForSeconds(2);
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return new WaitForSeconds(2);
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return new WaitForSeconds(4);
            }
    }
    IEnumerator beats()
    {
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return new WaitForSeconds(2);
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return new WaitForSeconds(2);
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return new WaitForSeconds(2);
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashLong());
        yield return new WaitForSeconds(2);
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return StartCoroutine(morseCodeFlash.GetComponent<morseCodeFlash>().FlashShort());
        yield return new WaitForSeconds(4);
    }
}
