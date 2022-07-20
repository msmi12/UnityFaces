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
           StartCoroutine(takeSnapshot());
        
        
    }
    

    string SnapshotName(int i)
    {
        return string.Format("{0}/Snapshots/snap_{1}x{2}_{3}_{4}_{5}_{6}.png", Application.dataPath, resWidth, resHeight, i, snapCam.name, Random.Range(1,100), System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));

    }

    IEnumerator takeSnapshot()
    {     
        for (int i=1; i<=cF; i++)
        {
            Debug.Log($"incearca saracu{this.gameObject.name}");
           // snapCam.gameObject.SetActive(true);
            //if (snapCam.gameObject.activeInHierarchy)
           // {

                Texture2D snapshot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
                snapCam.Render();
                RenderTexture.active = snapCam.targetTexture;
                snapshot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
                byte[] bytes = snapshot.EncodeToPNG();
                string fileName = SnapshotName(i);
                System.IO.File.WriteAllBytes(fileName, bytes);
                Debug.Log($"Snapshot taken!{snapCam.gameObject.name}");

                yield return new WaitForSeconds(2f);

            //}
        }
    }
}
