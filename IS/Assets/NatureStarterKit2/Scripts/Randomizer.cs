using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public RandomTransform randomTransform;
    public PhoC phoC;
    int cF;
    void Start()
    {
        cF = phoC.countF;
        Debug.Log(cF);
        //StartCoroutine(schimbPozitie());
            //randomTransform.ReturnValues();
         
    }
    internal void schimbPozitie()
    {
        //for(int i=1; i<= cF; i++)
        //{
            randomTransform.RandomizeValues(randomTransform.x, randomTransform.y, randomTransform.z, randomTransform.minInclusiveRotation, randomTransform.maxInclusiveRotation, randomTransform.minInclusivePosition, randomTransform.maxInclusivePosition);
            //yield return new WaitForSeconds(2f);
       // }
    }
}
