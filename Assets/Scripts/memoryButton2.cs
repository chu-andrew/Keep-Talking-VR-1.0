using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memoryButton2 : MonoBehaviour {
    public static bool stage1Button2 = false;
    public static bool stage2Button2 = false;
    public static bool stage3Button2 = false;
    public static bool stage4Button2 = false;
    private bool stop = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }
    private void OnMouseDown()
    {
        stop = false;
        if (chooseMemoryNum.roundNum == 1 && !memoryModuleClear.clearMmemoryModule && !stop)
        {
            if(chooseMemoryNum.displayNum == 1 || chooseMemoryNum.displayNum == 2)
            {
                chooseMemoryNum.roundNum = 2;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage1Button2 = true;
            }
            else
            {
                memoryButton1.reset(2);
            }
        }
        else if (chooseMemoryNum.roundNum == 2 && !memoryModuleClear.clearMmemoryModule && !stop)
        {
            if (chooseMemoryNum.displayNum == 1 && chooseMemoryNum.labelNum2[1] == 4)
            {
                chooseMemoryNum.roundNum = 3;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage2Button2 = true;
            }
            else if(chooseMemoryNum.displayNum == 1)
            {
                memoryButton1.reset(2);
            }
            if (chooseMemoryNum.displayNum == 2 && stage1Button2)
            {
                chooseMemoryNum.roundNum = 3;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage2Button2 = true;
            }
            else if(chooseMemoryNum.displayNum == 2)
            {
                memoryButton1.reset(2);
            }
            if (chooseMemoryNum.displayNum == 3)
            {
                memoryButton1.reset(2);
            }
            if (chooseMemoryNum.displayNum == 4 && stage1Button2)
            {
                chooseMemoryNum.roundNum = 3;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage2Button2 = true;
            }
            else if (chooseMemoryNum.displayNum == 4)
            {
                memoryButton1.reset(2);
            }
        }
        else if(chooseMemoryNum.roundNum == 3 && !memoryModuleClear.clearMmemoryModule && !stop)
        {
            if (chooseMemoryNum.displayNum == 1)
            {
                if (memoryButton1.stage2Button1 && (chooseMemoryNum.labelNum2[0] == chooseMemoryNum.labelNum3[1]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button2 = true;
                }
                else if (memoryButton2.stage2Button2 && (chooseMemoryNum.labelNum2[1] == chooseMemoryNum.labelNum3[1]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button2 = true;
                }
                else if (memoryButton3.stage2Button3 && (chooseMemoryNum.labelNum2[2] == chooseMemoryNum.labelNum3[1]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button2 = true;
                }
                else if (memoryButton4.stage2Button4 && (chooseMemoryNum.labelNum2[3] == chooseMemoryNum.labelNum3[1]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button2 = true;
                }
                else
                {
                    memoryButton1.reset(2);
                }
            }
            if (chooseMemoryNum.displayNum == 2)
            {
                if (memoryButton1.stage1Button1 && (chooseMemoryNum.labelNum1[0] == chooseMemoryNum.labelNum3[1]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button2 = true;
                }
                else if (memoryButton2.stage1Button2 && (chooseMemoryNum.labelNum1[1] == chooseMemoryNum.labelNum3[1]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button2 = true;
                }
                else if (memoryButton3.stage1Button3 && (chooseMemoryNum.labelNum1[2] == chooseMemoryNum.labelNum3[1]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button2 = true;
                }
                else if (memoryButton4.stage1Button4 && (chooseMemoryNum.labelNum1[3] == chooseMemoryNum.labelNum3[1]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button2 = true;
                }
                else
                {
                    memoryButton1.reset(2);
                }
            }
            if (chooseMemoryNum.displayNum == 3)
            {
                memoryButton1.reset(2);
            }
            if (chooseMemoryNum.displayNum == 4 && chooseMemoryNum.labelNum3[1] == 4)
            {
                chooseMemoryNum.roundNum = 4;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage3Button2 = true;
            }
            else if(chooseMemoryNum.displayNum == 4)
            {
                memoryButton1.reset(2);
            }
        }
        else if(chooseMemoryNum.roundNum == 4 && !memoryModuleClear.clearMmemoryModule && !stop)
        {
            if (chooseMemoryNum.displayNum == 1 && stage1Button2)
            {
                chooseMemoryNum.roundNum = 5;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage4Button2 = true;
            }
            else if (chooseMemoryNum.displayNum == 1)
            {
                memoryButton1.reset(2);
            }
            if (chooseMemoryNum.displayNum == 2)
            {
                memoryButton1.reset(2);
            }
            if ((chooseMemoryNum.displayNum == 3 || chooseMemoryNum.displayNum == 4) && stage2Button2)
            {
                chooseMemoryNum.roundNum = 5;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage4Button2 = true;
            }
            else if (chooseMemoryNum.displayNum == 3 || chooseMemoryNum.displayNum == 4)
            {
                memoryButton1.reset(2);
            }
        }
        else if(chooseMemoryNum.roundNum == 5 && !memoryModuleClear.clearMmemoryModule && !stop)
        {
            if (chooseMemoryNum.displayNum == 1)
            {
                if (memoryButton1.stage1Button1 && (chooseMemoryNum.labelNum1[0] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton2.stage1Button2 && (chooseMemoryNum.labelNum1[1] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton3.stage1Button3 && (chooseMemoryNum.labelNum1[2] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton4.stage1Button4 && (chooseMemoryNum.labelNum1[3] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else
                {
                    memoryButton1.reset(2);
                }
            }
            if (chooseMemoryNum.displayNum == 2)
            {
                if (memoryButton1.stage2Button1 && (chooseMemoryNum.labelNum2[0] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton2.stage2Button2 && (chooseMemoryNum.labelNum2[1] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton3.stage2Button3 && (chooseMemoryNum.labelNum2[2] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton4.stage2Button4 && (chooseMemoryNum.labelNum2[3] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else
                {
                    memoryButton1.reset(2);
                }
            }
            if (chooseMemoryNum.displayNum == 3)
            {
                if (memoryButton1.stage4Button1 && (chooseMemoryNum.labelNum4[0] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton2.stage4Button2 && (chooseMemoryNum.labelNum4[1] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton3.stage4Button3 && (chooseMemoryNum.labelNum4[2] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton4.stage4Button4 && (chooseMemoryNum.labelNum4[3] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else
                {
                    memoryButton1.reset(2);
                }
            }
            if (chooseMemoryNum.displayNum == 4)
            {
                if (memoryButton1.stage3Button1 && (chooseMemoryNum.labelNum3[0] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton2.stage3Button2 && (chooseMemoryNum.labelNum3[1] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton3.stage3Button3 && (chooseMemoryNum.labelNum3[2] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton4.stage3Button4 && (chooseMemoryNum.labelNum3[3] == chooseMemoryNum.labelNum5[1]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else
                {
                    memoryButton1.reset(2);
                }
            }
        }
    }
    private void OnMouseUp()
    {
        stop = true;
    }
}
