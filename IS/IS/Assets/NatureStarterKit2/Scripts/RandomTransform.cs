using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTransform : MonoBehaviour
{
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;
    public float minInclusiveRotation = 0f;
    public float maxInclusiveRotation = 10f;
    public float minInclusivePosition = 0f;
    public float maxInclusivePosition = 10f;
    public Vector3 startPosition;
    public Quaternion startRotation;
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }
    public void RandomizeValues(float x, float y,float z, float minInclusiveRotation, float maxInclusiveRotation, float minInclusivePosition, float maxInclusivePosition)
    {

        this.transform.position = GetRandomRotations(x, y, z, minInclusivePosition, maxInclusivePosition, this.transform.position);
        this.transform.rotation = Quaternion.Euler(GetRandomRotations(x, y, z, minInclusiveRotation, maxInclusiveRotation, this.transform.rotation.eulerAngles));
    }

    //public void ReturnValues()
    //{
      //  this.transform.position= startPosition;
      //  this.transform.rotation = startRotation;
    //}
    
    private Vector3 GetRandomRotations(float x, float y, float z, float min, float max , Vector3 currentRotation)
    {
       
        x = Random.Range(min, max) + currentRotation.x;
      
        y = Random.Range(min, max) + currentRotation.y;

        z = Random.Range(min, max) + currentRotation.z;

        return new Vector3(x, y, z);
    }

  
}


   

