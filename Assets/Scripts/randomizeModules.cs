using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizeModules : MonoBehaviour {
    // Use this for initialization
    public static int chooseModule1 = 0;
    public static int chooseModule2 = 0;
    public static int chooseModule3 = 0;
    public static int chooseModule4 = 0;
    public static int chooseModule5 = 0;
    public static int chooseModule6 = 0;
    public static int chooseModule7 = 0;
    public static int chooseModule8 = 0;
    public static int chooseModule9 = 0;
    private int i1;
    private int i2;
    private int i3;
    private int i4;
    private int i5;
    private int i6;
    private bool choseModules =false;

    void Start () {
        chooseModule1 = 0;
        chooseModule2 = 0;
        chooseModule3 = 0;
        chooseModule4 = 0;
        chooseModule5 = 0;
        chooseModule6 = 0;
        chooseModule7 = 0;
        chooseModule8 = 0;
        chooseModule9 = 0;
        choseModules = false;
        i1 = 0;
        i2 = 0;
        i3 = 0;
        i4 = 0;
        i5 = 0;
        i6 = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (switchCamera.difficulty != 0 && !choseModules)
        {
            if (switchCamera.difficulty == 1)
            {
                i1 = Random.Range(1, 10);
                i2 = Random.Range(1, 10);
                i3 = Random.Range(1, 10);
                i4 = Random.Range(1, 10);

                // make sure the four numbers are all distinct
                while (i1 == i2 || i1 == i3 || i1 == i4 || i2 == i3 || i2 == i4 || i3 == i4)
                {
                    i1 = Random.Range(1, 10);
                    i2 = Random.Range(1, 10);
                    i3 = Random.Range(1, 10);
                    i4 = Random.Range(1, 10);
                }

                if (i1 == 1 || i2 == 1 || i3 == 1 || i4 == 1)
                {                   
                    chooseModule1 = Random.Range(1, 8);
                }
                if (i1 == 2 || i2 == 2 || i3 == 2 || i4 == 2)
                {
                    chooseModule2 = Random.Range(1, 8);
                }
                if (i1 == 3 || i2 == 3 || i3 == 3 || i4 == 3)
                {
                    chooseModule3 = Random.Range(1, 8); 
                }
                if (i1 == 4 || i2 == 4 || i3 == 4 || i4 == 4)
                {
                    chooseModule4 = Random.Range(1, 8);   
                }
                if (i1 == 5 || i2 == 5 || i3 == 5 || i4 == 5)
                {
                    chooseModule5 = Random.Range(1, 8);
                }
                if (i1 == 6 || i2 == 6 || i3 == 6 || i4 == 6)
                {
                    chooseModule6 = Random.Range(1, 8);
                }
                if (i1 == 7 || i2 == 7 || i3 == 7 || i4 == 7)
                {
                    chooseModule7 = Random.Range(1, 8);
                }
                if (i1 == 8 || i2 == 8 || i3 == 8 || i4 == 8)
                {
                    chooseModule8 = Random.Range(1, 8);
                }
                if (i1 == 9 || i2 == 9 || i3 == 9 || i4 == 9)
                {
                    chooseModule9 = Random.Range(1, 8);
                }
                /*
                Debug.Log(chooseModule1);
                Debug.Log(chooseModule2);
                Debug.Log(chooseModule3);
                Debug.Log(chooseModule4);
                Debug.Log(chooseModule5);
                Debug.Log(chooseModule6);
                Debug.Log(chooseModule7);
                Debug.Log(chooseModule8);
                Debug.Log(chooseModule9);
                */
            }
            if (switchCamera.difficulty == 2)
            {
                i1 = Random.Range(1, 10);
                i2 = Random.Range(1, 10);
                i3 = Random.Range(1, 10);
                i4 = Random.Range(1, 10);
                i5 = Random.Range(1, 10);
                i6 = Random.Range(1, 10);
                while (i1 == i2 || i1 == i3 || i1 == i4 || i2 == i3 || i2 == i4 || i3 == i4 || i1 == i5 || i2 == i5 || i3 == i5 || i4 == i5 || i5 == i6 || i1 == i6 || i2 == i6 || i3 == i6 || i4 == i6)
                {
                    i1 = Random.Range(1, 10);
                    i2 = Random.Range(1, 10);
                    i3 = Random.Range(1, 10);
                    i4 = Random.Range(1, 10);
                    i5 = Random.Range(1, 10);
                    i6 = Random.Range(1, 10);
                }
                if (i1 == 1 || i2 == 1 || i3 == 1 || i4 == 1 || i5 == 1 || i6 == 1)
                {  
                    chooseModule1 = Random.Range(1, 8);
                }
                if (i1 == 2 || i2 == 2 || i3 == 2 || i4 == 2 || i5 == 2 || i6 == 2)
                {
                    chooseModule2 = Random.Range(1, 8);
                }
                if (i1 == 3 || i2 == 3 || i3 == 3 || i4 == 3 || i5 == 3 || i6 == 3)
                {
                    chooseModule3 = Random.Range(1, 8);
                }
                if (i1 == 4 || i2 == 4 || i3 == 4 || i4 == 4 || i5 == 4 || i6 == 4)
                {
                    chooseModule4 = Random.Range(1, 8);
                }
                if (i1 == 5 || i2 == 5 || i3 == 5 || i4 == 5 || i5 == 5 || i6 == 5)
                {
                    chooseModule5 = Random.Range(1, 8);
                }
                if (i1 == 6 || i2 == 6 || i3 == 6 || i4 == 6 || i5 == 6 || i6 == 6)
                {
                    chooseModule6 = Random.Range(1, 8);
                }
                if (i1 == 7 || i2 == 7 || i3 == 7 || i4 == 7 || i5 == 7 || i6 == 7)
                {
                    chooseModule7 = Random.Range(1, 8);
                }
                if (i1 == 8 || i2 == 8 || i3 == 8 || i4 == 8 || i5 == 8 || i6 == 8)
                {
                    chooseModule8 = Random.Range(1, 8);
                }
                if (i1 == 9 || i2 == 9 || i3 == 9 || i4 == 9 || i5 == 9 || i6 == 9)
                {
                    chooseModule9 = Random.Range(1, 8);
                }
            }
            if (switchCamera.difficulty == 3)
            {

                chooseModule1 = Random.Range(1, 8);
                chooseModule2 = Random.Range(1, 8);
                chooseModule3 = Random.Range(1, 8);
                chooseModule4 = Random.Range(1, 8);
                chooseModule5 = Random.Range(1, 8);
                chooseModule6 = Random.Range(1, 8);
                chooseModule7 = Random.Range(1, 8);
                chooseModule8 = Random.Range(1, 8);
                chooseModule9 = Random.Range(1, 8);
                int random2 = Random.Range(1, 10);                
                switch (random2)
                {
                    case 1:
                        chooseModule1 = 9;
                        break;
                    case 2:
                        chooseModule2 = 9;
                        break;
                    case 3:
                        chooseModule3 = 9;
                        break;
                    case 4:
                        chooseModule4 = 9;
                        break;
                    case 5:
                        chooseModule5 = 9;
                        break;
                    case 6:
                        chooseModule6 = 9;
                        break;
                    case 7:
                        chooseModule7 = 9;
                        break;
                    case 8:
                        chooseModule8 = 9;
                        break;
                    case 9:
                        chooseModule9 = 9;
                        break;
                }
                Debug.Log(chooseModule1);
                Debug.Log(chooseModule2);
                Debug.Log(chooseModule3);
                Debug.Log(chooseModule4);
                Debug.Log(chooseModule5);
                Debug.Log(chooseModule6);
                Debug.Log(chooseModule7);
                Debug.Log(chooseModule8);
                Debug.Log(chooseModule9);
            }
            if(switchCamera.difficulty == 4)
            {
                i1 = Random.Range(1, 10);
                if (i1 == 1)
                {
                    chooseModule1 = Random.Range(8, 9);
                }
                if (i1 == 2)
                {
                    chooseModule2 = Random.Range(8, 9);
                }
                if (i1 == 3)
                {
                    chooseModule3 = Random.Range(8, 9);
                }
                if (i1 == 4 )
                {
                    chooseModule4 = Random.Range(8, 9);
                }
                if (i1 == 5)
                {
                    chooseModule5 = Random.Range(8, 9);
                }
                if (i1 == 6)
                {
                    chooseModule6 = Random.Range(8, 9);
                }
                if (i1 == 7)
                {
                    chooseModule7 = Random.Range(8, 9);
                }
                if (i1 == 8)
                {
                    chooseModule8 = Random.Range(8, 9);
                }
                if (i1 == 9)
                {
                    chooseModule9 = Random.Range(8, 9);
                }
            }
            if (switchCamera.difficulty == 5)
            {
                i1 = Random.Range(1, 10);
                if (i1 == 1)
                {
                    chooseModule1 = Random.Range(1, 9);
                }
                if (i1 == 2)
                {
                    chooseModule2 = Random.Range(1, 9);
                }
                if (i1 == 3)
                {
                    chooseModule3 = Random.Range(1, 9);
                }
                if (i1 == 4)
                {
                    chooseModule4 = Random.Range(1, 9);
                }
                if (i1 == 5)
                {
                    chooseModule5 = Random.Range(1, 9);
                }
                if (i1 == 6)
                {
                    chooseModule6 = Random.Range(1, 9);
                }
                if (i1 == 7)
                {
                    chooseModule7 = Random.Range(1, 9);
                }
                if (i1 == 8)
                {
                    chooseModule8 = Random.Range(1, 9);
                }
                if (i1 == 9)
                {
                    chooseModule9 = Random.Range(1, 9);
                }
            }
            choseModules = true;
        }
    }
}
