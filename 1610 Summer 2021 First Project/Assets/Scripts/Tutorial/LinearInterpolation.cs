using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        // In this case, result = 4
        float resultFloat = Mathf.Lerp(3f, 5f, 0.5f);

        Vector3 from = new Vector3(1f, 2f, 3f);
        Vector3 to = new Vector3(5f, 6f, 7f);

        // Here result = (4, 5, 6)
        Vector3 resultVector3 = Vector3.Lerp(from, to, 0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        // frame rate dependant
        myLight.intensity = Mathf.Lerp(myLight.intensity, 8f, 0.5f);

        // not frame rate dependant
        myLight.intensity = Mathf.Lerp(myLight.intensity, 8f, 0.5f * Time.deltaTime);
    }
}
