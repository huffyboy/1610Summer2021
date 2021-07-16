using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // SWITCH /////////////////////////////////////////////
        int day = 4;
        switch (day)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("Wednesday");
                break;
            case 4:
                Debug.Log("Thursday");
                break;
            case 5:
                Debug.Log("Friday");
                break;
            case 6:
                Debug.Log("Saturday");
                break;
            case 7:
                Debug.Log("Sunday");
                break;
        }
        // Outputs "Thursday" (day 4)

        // DEFAULT ///////////////////////////////////////////////
        day = 4;
        switch (day)
        {
            case 6:
                Debug.Log("Today is Saturday.");
                break;
            case 7:
                Debug.Log("Today is Sunday.");
                break;
            default:
                Debug.Log("Looking forward to the Weekend.");
                break;
        }
        // Outputs "Looking forward to the Weekend."
    }
}
