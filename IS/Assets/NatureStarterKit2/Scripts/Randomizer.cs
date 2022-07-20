using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public RandomTransform randomTransform;
    PhoC phoC;
    //void Update()
    void Start()
    {
        StartCoroutine(schimbPozitie());
            //randomTransform.ReturnValues();
         
    }
    IEnumerator schimbPozitie()
    {
        for(int i=1; i<= phoC.countF; i++)
        {
            randomTransform.RandomizeValues(randomTransform.x, randomTransform.y, randomTransform.z, randomTransform.minInclusiveRotation, randomTransform.maxInclusiveRotation, randomTransform.minInclusivePosition, randomTransform.maxInclusivePosition);
            yield return new WaitForSeconds(2f);
        }
    }
}
