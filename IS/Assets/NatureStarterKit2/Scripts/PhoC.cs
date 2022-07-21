using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PhoC : MonoBehaviour
{
    public GameObject gameObject;
    public Texture2D texture;
    public int countF;
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

    void Awake()
    {

        countF = Directory.GetFiles(@"D:\INTERNSHIP\IS\Assets\NatureStarterKit2\Buletine", "*.jpg", SearchOption.TopDirectoryOnly).Length;
    }
   // void Start()

   // {
        
      //  StartCoroutine(schimbPoze());

   // }
    internal void schimbPoze(int i)
    { //for (int i = 1; i <= countF; i++)
       // {
            filePath = (@$"D:\INTERNSHIP\IS\Assets\NatureStarterKit2\Buletine\foto {i}.jpg");
            Texture2D texture = LoadPNG(filePath);
            gameObject.GetComponent<Renderer>().material.mainTexture = texture;
            Debug.Log($"poza {i} a fost incarcata");
           // yield return new WaitForSeconds(2f);
            
       // }
    }
}

