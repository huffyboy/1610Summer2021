using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        // don't allow the plane to tilt in other directions
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0f, 0f);

        /* slowly remove collision tilt ?
        float yRotation = transform.rotation.eulerAngles.y * 0.5f;
        float zRotation = transform.rotation.eulerAngles.z * 0.5f;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, yRotation, zRotation);*/
    }
}
