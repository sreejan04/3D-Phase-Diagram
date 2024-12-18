using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRControls : MonoBehaviour
{
    public sectionsGen secGen;
    public Rotate meshRot;

    public float secSpeed = 5f;

    void Update()
    {
        float rightThumb = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y;
        float leftThumb = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y;

        secGen.temp = Mathf.Clamp(secGen.temp + leftThumb * secSpeed, 100f, 1500f);
        meshRot.rotateMesh(rightThumb);
    }
}
