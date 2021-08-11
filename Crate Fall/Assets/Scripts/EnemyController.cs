using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public MoveScript moveScript;
    public float forwardInput = 0f;
    public float sideInput = 0f;
    public float rotationInput = 0f;
    private float updatDirDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomizeInputs", 0f, updatDirDelay);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        forwardInput = RandomlyAdjustInput(forwardInput, -0.5f, 1f);
        sideInput = RandomlyAdjustInput(sideInput, -0.5f, 0.5f);
        rotationInput = RandomlyAdjustInput(rotationInput);

        moveScript.forwardInput = forwardInput;
        moveScript.sideInput = sideInput;
        moveScript.rotationInput = rotationInput;
    }

    private void RandomizeInputs()
    {
        forwardInput = Random.Range(-1f, 1f);
        sideInput = Random.Range(-1f, 1f);
        rotationInput = Random.Range(-1f, 1f);
    }

    private float RandomlyAdjustInput(float value, float min = -1f, float max = 1f)
    {
        value = value + (Random.Range(min, max) * 0.05f);
        if (value < min)
        {
            value += 1 + max;
        } else if (value > max)
        {
            value -= 1 + min;
        }

        return value;
    }
}
