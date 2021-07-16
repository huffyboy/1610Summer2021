using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int myNum = 5;               // Integer (whole number)
        double myDoubleNum = 5.99D;  // Floating point number
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myText = "Hello";     // String

        Debug.Log("Integer     : " + myNum);
        Debug.Log("Float/Double: " + myDoubleNum);
        Debug.Log("Char        : " + myLetter);
        Debug.Log("Boolean     : " + myBool);
        Debug.Log("String      : " + myText);


        int myInt = 100000;
        Debug.Log(myInt);

        long myLong = 15000000000L;
        Debug.Log(myLong);

        float myFloat = 5.75F;
        Debug.Log(myFloat);

        double myDouble = 19.99D;
        Debug.Log(myDouble);

        float f1 = 35e3F;
        double d1 = 12E4D;
        Debug.Log(f1);
        Debug.Log(d1);
    }
}
