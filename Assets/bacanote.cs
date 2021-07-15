using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class bacanote : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/textHere.txt";

        //Read the text from directly from the test.txt file
        string[] lines = System.IO.File.ReadAllLines(path);
        //StreamReader reader = new StreamReader(path); 
        //Debug.Log(reader.ReadToEnd());
        //reader.Close();
        foreach (string line in lines)
        {
            // Use a tab to indent each line of the file.
            Debug.Log(line);
        } 
    }

}
