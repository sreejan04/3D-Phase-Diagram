using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 1.0f;
    //public GameObject parent;
    private int size = 64;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.LeftArrow))
        if(OVRInput.Get(OVRInput.RawAxis2D.LThumbstick).x>0)
        {
            rotateMesh(-1f);
            //Debug.Log("LThumbstick " + OVRInput.Get(OVRInput.RawAxis2D.LThumbstick));
        }
        //if (Input.GetKey(KeyCode.RightArrow))
        if (OVRInput.Get(OVRInput.RawAxis2D.LThumbstick).x < 0)
        {
            rotateMesh(1f);
            //Debug.Log("LThumbstick " + OVRInput.Get(OVRInput.RawAxis2D.LThumbstick));
        }
    }

    public void rotateMesh(float amount)
    {
        transform.RotateAround(new Vector3(size / 2, 0, -size / 2), Vector3.up, amount * rotateSpeed * Time.deltaTime);
    }

    
}
