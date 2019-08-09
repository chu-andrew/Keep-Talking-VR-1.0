using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotateBomb : MonoBehaviour
{
    float rotSpeed = 200;
    public float speed = 20f;
    Ray r;
    RaycastHit rh;
    private void Start()
    {
        
    }
    /*
    void Update()
    {
        r = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(r, out rh, 1000))
        {
            if (rh.collider.gameObject.tag == "rot")
            {
                if (Input.GetMouseButton(0))
                {
                    transform.Rotate(0, (Input.GetAxis("Mouse X") * speed * -Time.deltaTime), 0, Space.World);
                }
            }
        }
    }
    */
    // Update is called once per frame
    void Update () {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * rotSpeed);
    }
}