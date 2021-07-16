using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // IF ///////////////////////////////////////////////////////////
        int x = 20;
        int y = 18;
        if (x > y)
        {
            Debug.Log("x is greater than y");
        }

        // ELSE ///////////////////////////////////////////////////////////
        int time = 20;
        if (time < 18)
        {
            Debug.Log("Good day.");
        }
        else
        {
            Debug.Log("Good evening.");
        }
        // Outputs "Good evening."

        // ELSE IF ///////////////////////////////////////////////////////////
        time = 22;
        if (time < 10)
        {
            Debug.Log("Good morning.");
        }
        else if (time < 20)
        {
            Debug.Log("Good day.");
        }
        else
        {
            Debug.Log("Good evening.");
        }
        // Outputs "Good evening."

        // Ternary Operator ///////////////////////////////////////////////////////////
        time = 20;
        string result = (time < 18) ? "Good day." : "Good evening.";
        Debug.Log(result);
    }
}
