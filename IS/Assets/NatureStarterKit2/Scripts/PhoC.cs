using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PhoC : MonoBehaviour
{
    GameObject CoroutineManager;
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
            //Debug.Log("merge");
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
        }
        return tex;
    }

    void Awake()
    {
        CoroutineManager = GameObject.Find("CoroutineManager");
        CoroutineManager2 cm= CoroutineManager.GetComponent<CoroutineManager2>();
        string folderName = cm.folderName;
        string subfolderName = cm.subfolderName;
        string rootFileName = cm.rootFileName;
        if(subfolderName!=null)
        countF = Directory.GetFiles($@"D:\UnityFaces\IS\Assets\NatureStarterKit2\{folderName}\{subfolderName}", "*.jpg", SearchOption.TopDirectoryOnly).Length;
        else
            countF = Directory.GetFiles($@"D:\UnityFaces\IS\Assets\NatureStarterKit2\{folderName}", "*.jpg", SearchOption.TopDirectoryOnly).Length;

<<<<<<< Updated upstream
        countF = Directory.GetFiles(@"D:\INTERNSHIP\IS\Assets\NatureStarterKit2\Buletine", "*.jpg", SearchOption.TopDirectoryOnly).Length;
=======
>>>>>>> Stashed changes
    }
   // void Start()

   // {
        
      //  StartCoroutine(schimbPoze());

   // }
    internal void schimbPoze(string folderName, string subfolderName, string rootFileName, int i)
    { //for (int i = 1; i <= countF; i++)
       // {
<<<<<<< Updated upstream
            filePath = (@$"D:\INTERNSHIP\IS\Assets\NatureStarterKit2\Buletine\foto {i}.jpg");
=======
            if(subfolderName!=null)
        {
            filePath = (@$"D:\UnityFaces\IS\Assets\NatureStarterKit2\{folderName}\{subfolderName}\{rootFileName}.{i}.jpg");
        }
            else
        {
            filePath = (@$"D:\UnityFaces\IS\Assets\NatureStarterKit2\{folderName}\{rootFileName}.{i}.jpg");
        }
            
>>>>>>> Stashed changes
            Texture2D texture = LoadPNG(filePath);
            gameObject.GetComponent<Renderer>().material.mainTexture = texture;
            Debug.Log($"poza {i} a fost incarcata");
           // yield return new WaitForSeconds(2f);
            
       // }
    }
}

