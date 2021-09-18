using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morseCodeInstantiate : MonoBehaviour {

    public GameObject prefab;
    public Transform parentObject;
    public static int stop = 0;
    public static int stop1 = 0;
    public static int stop2 = 0;
    public static int stop3 = 0;
    public static int stop4 = 0;
    public static int stop5 = 0;
    public static int stop6 = 0;
    public static int stop7 = 0;
    public static int stop8 = 0;

    // Use this for initialization
    void Start()
    {
        stop = 0;
        stop1 = 0;
        stop2 = 0;
        stop3 = 0;
        stop4 = 0;
        stop5 = 0;
        stop6 = 0;
        stop7 = 0;
        stop8 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == 0 && randomizeModules.chooseModule1 == 7)
        {
            Quaternion rotation = Quaternion.Euler(0, -90, 0);
            GameObject clone = Instantiate(prefab, new Vector3(-0.07127906f, 1.620987f, -6.8525f), rotation, parentObject);
            stop = 1;
        }
        if (stop1 == 0 && randomizeModules.chooseModule2 == 7)
        {
            Quaternion rotation = Quaternion.Euler(0, -90, 0);
            GameObject clone = Instantiate(prefab, new Vector3(0.05622103f, 1.620987f, -6.8525f), rotation, parentObject);
            stop1 = 1;
        }
        if (stop2 == 0 && randomizeModules.chooseModule3 == 7)
        {
            Quaternion rotation = Quaternion.Euler(0, -90, 0);
            GameObject clone = Instantiate(prefab, new Vector3(0.1862211f, 1.620987f, -6.8525f), rotation, parentObject);
            stop2 = 1;
        }
        if (stop3 == 0 && randomizeModules.chooseModule4 == 7)
        {
            Quaternion rotation = Quaternion.Euler(0, -90, 0);
            GameObject clone = Instantiate(prefab, new Vector3(-0.07127906f, 1.500238f, -6.8525f), rotation, parentObject);
            stop3 = 1;
        }
        if (stop4 == 0 && randomizeModules.chooseModule5 == 7)
        {
            Quaternion rotation = Quaternion.Euler(0, -90, 0);
            GameObject clone = Instantiate(prefab, new Vector3(0.05622103f, 1.500238f, -6.8525f), rotation, parentObject);
            stop4 = 1;
        }
        if (stop5 == 0 && randomizeModules.chooseModule6 == 7)
        {
            Quaternion rotation = Quaternion.Euler(0, -90, 0);
            GameObject clone = Instantiate(prefab, new Vector3(0.1862211f, 1.500238f, -6.8525f), rotation, parentObject);
            stop5 = 1;
        }
        if (stop6 == 0 && randomizeModules.chooseModule7 == 7)
        {
            Quaternion rotation = Quaternion.Euler(0, -90, 0);
            GameObject clone = Instantiate(prefab, new Vector3(-0.07127906f, 1.372238f, -6.8525f), rotation, parentObject);
            stop6 = 1;
        }
        if (stop7 == 0 && randomizeModules.chooseModule8 == 7)
        {
            Quaternion rotation = Quaternion.Euler(0, -90, 0);
            GameObject clone = Instantiate(prefab, new Vector3(0.05622103f, 1.372238f, -6.8525f), rotation, parentObject);
            stop7 = 1;
        }
        if (stop8 == 0 && randomizeModules.chooseModule9 == 7)
        {
            Quaternion rotation = Quaternion.Euler(0, -90, 0);
            GameObject clone = Instantiate(prefab, new Vector3(0.1862212f, 1.372238f, -6.8525f), rotation, parentObject);
            stop8 = 1;
        }
    }
}
