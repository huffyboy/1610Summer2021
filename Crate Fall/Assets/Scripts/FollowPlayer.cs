using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;// = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    /*
    public float sensitivity;
    void FixedUpdate()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        transform.RotateAround(player.transform.position, -Vector3.up, rotateHorizontal * sensitivity);
        //use
        //transform.Rotate(-transform.up * rotateHorizontal * sensitivity);
        //instead if you dont want the camera to rotate around the player

        transform.RotateAround(Vector3.zero, transform.right, rotateVertical * sensitivity);
        // again, use
        //transform.Rotate(transform.right * rotateVertical * sensitivity);
        // if you don't want the camera to rotate around the player
    }*/

    public float speedH = 2f;
    public float speedV = 2f;

    public float yaw = 0f;
    public float pitch = 0f;
    // Update is called once per frame
    void LateUpdate()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0f);
        player.transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);

        //transform.position = player.transform.position + offset;
        transform.position = player.transform.position;
    }
}
