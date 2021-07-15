using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using static PlayerPrefsX;

public class ReadDatabaseScript : MonoBehaviour
{
    
    void Start()
    {   
        string judulDB = "Assets/DBJudul.txt";
        string descDB = "Assets/DBDesc.txt";

        string[] linesa = System.IO.File.ReadAllLines(judulDB);
        string[] linesb = System.IO.File.ReadAllLines(descDB);

        PlayerPrefsX.SetStringArray("inijudul", linesa); 
        PlayerPrefsX.SetStringArray("inideskripsi", linesb);

    }
}
