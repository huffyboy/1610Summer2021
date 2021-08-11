using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public MoveScript moveScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveScript.forwardInput = Input.GetAxis("Vertical");
        moveScript.sideInput = Input.GetAxis("Horizontal");
    }
}
