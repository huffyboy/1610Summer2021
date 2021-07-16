using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // FOREACH LOOP ///////////////////////////////////
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string i in cars)
        {
            Debug.Log(i);
        }



        var myDictionary = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("Carrot","If I eat enough of these, maybe I'll turn into a rabbit or get super vision."),
            new KeyValuePair<string, string>("Cabbage","Hmmm. I guess they're okay. Unless it turns out to be a cabbage patch child."),
            new KeyValuePair<string, string>("Magazine","To be honest I haven't really read them. I mainly just look at the images."),
            new KeyValuePair<string, string>("Gun","Now that's a mighty fine weapon. Too bad I don't have any bullets."),
        };

        foreach (KeyValuePair<string, string> entry in myDictionary)
        {
            // do something with entry.Value or entry.Key
            string logEntry = "Log Entry for: " + entry.Key + "\r\n\r\n";
            logEntry += entry.Value + "\r\n\r\n";
            logEntry += "End of Log...\n";
            Debug.Log(logEntry);
        }
    }
}
