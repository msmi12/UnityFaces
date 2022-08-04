using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class Rename : MonoBehaviour
{   
    void Start()
    {
        rename();
    }
    
    void rename()
    {
        var rootDir = @"D:\UnityFaces\IS\Assets\NatureStarterKit2\ToRename";
        var fileNames = Directory.EnumerateFiles(rootDir, "*.jpg");
        int i = 1;  
            foreach (var path in fileNames)
            {
                Debug.Log(path);        
                 string rename = @$"D:\UnityFaces\IS\Assets\NatureStarterKit2\ToRename\foto {i}.jpg";
                File.Move(path, rename);
                i++;
            }   
    }
}
