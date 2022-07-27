using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineManager : MonoBehaviour
{
    /*public GameObject[] automatedObj;
    internal PhoC phoC;
            Randomizer randomizer;
            Snapshot snapshot;
    [SerializeField] public GameObject sun;
    public GameObject standardBuletin;
    int cF;
    [SerializeField] int numarSchimbariPePoza= 3;
    void Start()
    {  
        automatedObj = GameObject.FindGameObjectsWithTag("auto");
        cF = standardBuletin.GetComponent<PhoC>().countF;      
         // if (automatedObj[j] != sun)
            
                StartCoroutine(automatizareaProceselor());
            
          //  else
            //{ StartCoroutine(randomizarePozitie());
          //  }
        
    }

   IEnumerator automatizareaProceselor()
    { for(int i=1; i<=cF;i++)
        {
            for (int j = 0; j < automatedObj.Length; j++)
            {
                if (automatedObj[j].GetComponent<PhoC>() != null)
                {
                    automatedObj[j].GetComponent<PhoC>().schimbPoze(i);
                }
               
                // if (j > 1 && j % 2 == 1)
                // {
                   // for (int x = 1; x <= numarSchimbariPePoza; x++)
                  //  {
                        automatedObj[j].GetComponent<Randomizer>().schimbPozitie();
                      //  Debug.Log($"s a schimbat a {x} oara");
                        new WaitForSeconds(0.5f);
                        if (automatedObj[j+1].GetComponent<Snapshot>() != null)
                        {
                            automatedObj[j+1].GetComponent<Snapshot>().takeSnapshot(i);
                           // Debug.Log($"a facut ss a{x} oara");
                        }
                      //  continue;
                   // }
                //}
               // yield return new WaitForSeconds(0.5f);
                
            }
            yield return new WaitForSeconds(0.5f);
        }

    }
      
   // IEnumerator randomizarePozitie()
    //{
        //for(int i=1;i<=cF;i++)
       // {
       //     randomizer.schimbPozitie();
       //     yield return new WaitForSeconds(2.5f);
       // }
   // }
    */
}
