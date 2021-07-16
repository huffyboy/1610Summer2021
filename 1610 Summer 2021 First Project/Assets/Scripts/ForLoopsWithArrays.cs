using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // FOR LOOP //////////////////////////////////////
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        for (int i = 0; i <= 10; i = i + 2)
        {
            Debug.Log(i);
        }

        // ARRAYS ////////////////////////////////////////
        // Creation
        string[] cars1;
        string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
        int[] myNums = { 10, 20, 30, 40 };

        cars1 = new string[5];
        cars1[0] = "Cool Car Here";

        // Accessing
        string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };
        Debug.Log(cars3[0]);
        // Outputs Volvo

        // Changing Elements
        string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };
        cars4[0] = "Opel";
        Debug.Log(cars4[0]);
        // Now outputs Opel instead of Volvo

        // Array Length
        string[] cars5 = { "Volvo", "BMW", "Ford", "Mazda" };
        Debug.Log(cars5.Length);
        // Outputs 4

        // Looping through an array
        string[] cars6 = { "Volvo", "BMW", "Ford", "Mazda" };
        for (int i = 0; i < cars6.Length; i++)
        {
            Debug.Log(cars6[i]);
        }
    }
}
