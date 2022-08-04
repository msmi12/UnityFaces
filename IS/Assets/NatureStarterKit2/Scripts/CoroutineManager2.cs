using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineManager2 : MonoBehaviour
{
    public GameObject[] buletinObj;
    public GameObject[] cameraObj;
    [SerializeField] GameObject standardBuletin;
    [SerializeField] GameObject sun;
    Quaternion p;
    internal PhoC phoC;
    Randomizer randomizer;
    float m;
    Snapshot snapshot;
    int cF;
    [SerializeField] int numarSchimbariPePoza = 3;

    void Start()
    {
        m = 20f;
        buletinObj = GameObject.FindGameObjectsWithTag("buletin");
        cameraObj = GameObject.FindGameObjectsWithTag("ss");
        cF = standardBuletin.GetComponent<PhoC>().countF;
        StartCoroutine(automatizare());
       
    }


    IEnumerator automatizare()
    {
        for(int i=1; i<=cF;i++)
        {
            for(int j=0; j< cameraObj.Length;j++)
            {
                m = 20f;
                buletinObj[j].GetComponent<PhoC>().schimbPoze(i);
                for (int n = 0; n < numarSchimbariPePoza; n++)
                {             
                    buletinObj[j].GetComponent<Randomizer>().schimbPozitie();
                    cameraObj[j].GetComponent<Randomizer>().schimbPozitie();
                    cameraObj[j].GetComponent<Snapshot>().takeSnapshot(i,j,n);
                    Vector3 eulerRotation = new Vector3(m, -40, sun.transform.eulerAngles.z);
                    sun.transform.rotation = Quaternion.Euler(eulerRotation);
                     m += 20;
                    yield return new WaitForSeconds(0.5f);         
                }
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
