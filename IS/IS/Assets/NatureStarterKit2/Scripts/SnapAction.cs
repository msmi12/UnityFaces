using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapAction : MonoBehaviour
{
    public Snapshot snapCam;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            snapCam.CallTakeSnapshot();
            
        }
    }
}
