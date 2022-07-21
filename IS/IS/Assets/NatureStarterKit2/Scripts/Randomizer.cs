using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public RandomTransform randomTransform;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //randomTransform.ReturnValues();
            randomTransform.RandomizeValues(randomTransform.x, randomTransform.y, randomTransform.z, randomTransform.minInclusiveRotation, randomTransform.maxInclusiveRotation, randomTransform.minInclusivePosition, randomTransform.maxInclusivePosition);
        }
    }
}
