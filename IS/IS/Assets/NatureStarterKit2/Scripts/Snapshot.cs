using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Snapshot : MonoBehaviour
{
    Camera snapCam;

    int resWidth= 2048;
    int resHeight= 2048;

    void Awake()
    {
        snapCam = GetComponent<Camera>();
        if (snapCam.targetTexture== null)
        {
            snapCam.targetTexture = new RenderTexture(resWidth, resHeight, 24);

        }
        else
        {
            resWidth = snapCam.targetTexture.width;
            resHeight = snapCam.targetTexture.height;

        }

        snapCam.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void CallTakeSnapshot()
    {
        snapCam.gameObject.SetActive(true);
    }
    void LateUpdate()
    {
        if(snapCam.gameObject.activeInHierarchy)
        {
            Texture2D snapshot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            snapCam.Render();
            RenderTexture.active = snapCam.targetTexture;
            snapshot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
            byte[] bytes = snapshot.EncodeToPNG();
            string fileName = SnapshotName();
            System.IO.File.WriteAllBytes(fileName, bytes);
            Debug.Log("Snapshot taken!");
            snapCam.gameObject.SetActive(false);

        }
    }

    string SnapshotName()
    {
        return string.Format("{0}/Snapshots/snap_{1}x{2}_{3}_{4}.png", Application.dataPath, resWidth, resHeight, snapCam.name, System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));

    }
}
