using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PhoC : MonoBehaviour
{
    public GameObject gameObject;
    public Texture2D texture; 
    string filePath;
    Texture2D tex = null;
    byte[] fileData;
    public static Texture2D LoadPNG(string filePath)
    {
        Texture2D tex = null;
        byte[] fileData;

        if (File.Exists(filePath))
        {
            fileData = File.ReadAllBytes(filePath);
            Debug.Log("merge");
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
        }
        return tex;
    }
    void Start()

    {
        filePath = @"D:\INTERNSHIP\IS\Assets\NatureStarterKit2\Buletine\avatar-f277a93e33d8427ca160ce767159ef5b.jpg";       
        Texture2D texture= LoadPNG(filePath);
        gameObject.GetComponent<Renderer>().material.mainTexture = texture;
        Debug.Log(texture);
        
    }
    
}
