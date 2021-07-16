using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // WHILE //////////////////////////////////////////////
        int i = 0;
        while (i < 5)
        {
            Debug.Log(i);
            i++;
        }

        // DO WHILE ////////////////////////////////////////////
        int index = 0;
        do
        {
            Debug.Log(index);
            index++;
        }
        while (index < 5);
    }
}
