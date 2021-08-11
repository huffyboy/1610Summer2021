using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private float speed = 20f;
    public float forwardInput = 0f;
    public float sideInput = 0f;
    private float rotationSpeed = 90f;
    public float rotationInput = 0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float forwardMag = Mathf.Abs(forwardInput);
        float sideMag = Mathf.Abs(sideInput);
        float totalMag = forwardMag + sideMag;
        if (totalMag > 1f)
        {
            forwardMag = forwardMag / totalMag;
            sideMag = sideMag / totalMag;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardMag * Mathf.Sign(forwardInput));
        transform.Translate(Vector3.right * Time.deltaTime * speed * sideMag * Mathf.Sign(sideInput));

        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * rotationInput);
    }
}
