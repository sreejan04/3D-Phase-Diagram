using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sectionsGen : MonoBehaviour
{
    [Range(100f, 1500f)]
    public float temp;
    private float lastTemp;

    public Volume volume;
    public Material mat;
    public Transform cuttingPlane;

    Texture2D texture;
    int l, w;

    // Start is called before the first frame update
    void Start()
    {
        volume.loadImgs();
        l = volume.l;
        w = volume.w;

        texture = new Texture2D(w, l);

        cuttingPlane.position = new Vector3(cuttingPlane.position.x, (64*(temp))/1400f - 6.4f, cuttingPlane.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cuttingPlane.position.y);
        if (temp != lastTemp)
        {
            generateTexture();
        }

        lastTemp = temp;

        cuttingPlane.position = new Vector3(cuttingPlane.position.x, (64 * (temp)) / 1400f - 6.4f, cuttingPlane.position.z);
    }

    void generateTexture()
    {
        texture = volume.SampleAbs(l, w, temp);
        texture.filterMode = FilterMode.Point;
        texture.Apply();
        mat.mainTexture = texture;
    }
}
