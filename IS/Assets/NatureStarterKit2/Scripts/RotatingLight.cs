using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingLight : MonoBehaviour
{
  
    void Update()
    {
        transform.Rotate(0, .2f, 0);
    }
}
