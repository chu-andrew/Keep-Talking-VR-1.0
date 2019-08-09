using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placefront : MonoBehaviour
{
    public GameObject frontObject;
    public float distance;
    // Use this for initialization
    void Start()
    {
        //frontObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward * distance;

    }
    /*
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    printName(hit.transform.gameObject);
                }
            }
        }
    }
    void printName(GameObject go)
    {
        print(go.name);
    }
    */
    private void Update()
    {
        //transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
    }
    private void OnMouseDown()
    {
        transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
        Debug.Log("clicked on button");
    }
}