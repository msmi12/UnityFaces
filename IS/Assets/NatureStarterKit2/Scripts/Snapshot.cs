using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Snapshot : MonoBehaviour
{   [SerializeField]
    Camera snapCam;

    int resWidth= 2048;
    int resHeight= 2048;
    public PhoC phoC;
    int cF;
    


    void Start()
    {
        cF = phoC.countF;
        Debug.Log(cF);
        snapCam = GetComponent<Camera>();
        if (snapCam.targetTexture == null)
        {
            snapCam.targetTexture = new RenderTexture(resWidth, resHeight, 24);

        }
        else
        {
            resWidth = snapCam.targetTexture.width;
            resHeight = snapCam.targetTexture.height;

        }        
          // StartCoroutine(takeSnapshot());
        
        
    }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
    string SnapshotName(int i,int x)
    {
        return string.Format("{0}/Snapshots/snap_{1}-{2}_{3}.png", Application.dataPath, i,x, Random.Range(1,100));

    }

    internal void takeSnapshot(int i, int x)
=======
=======
>>>>>>> Stashed changes

    string SnapshotName(string rootFileName, int i,int j,int x)
    {
        return string.Format("{0}/Snapshots/ {1} {2}-{3}-{4}_{5}.png", Application.dataPath, rootFileName, i,j,x, Random.Range(1,100));

    }

    internal void takeSnapshot(string rootFileName, int i, int j,int x)
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    {     
        //for (int i=1; i<=cF; i++)
        //{
           // snapCam.gameObject.SetActive(true);
            //if (snapCam.gameObject.activeInHierarchy)
           // {

                Texture2D snapshot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
                snapCam.Render();
                RenderTexture.active = snapCam.targetTexture;
                snapshot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
                byte[] bytes = snapshot.EncodeToPNG();
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                string fileName = SnapshotName(i,x);
=======
                string fileName = SnapshotName(rootFileName,i,j,x);
>>>>>>> Stashed changes
=======
                string fileName = SnapshotName(rootFileName,i,j,x);
>>>>>>> Stashed changes
                System.IO.File.WriteAllBytes(fileName, bytes);
                Debug.Log($"Snapshot taken!{snapCam.gameObject.name}");

               // yield return new WaitForSeconds(2f);

            //}
       // }
    }
}
