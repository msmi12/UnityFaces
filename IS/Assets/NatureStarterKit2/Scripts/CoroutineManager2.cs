using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineManager2 : MonoBehaviour
{
    public GameObject[] buletinObj;
    public GameObject[] cameraObj;
    [SerializeField] GameObject standardBuletin;
    [SerializeField] GameObject sun;
    //numele folderului in care se afla pozele care trb schimbate (pisicile, cateii, buletinele), subfolderul si rootFileName (la buletine e foto, la pisici e cat etc)
    [SerializeField] public string folderName, subfolderName, rootFileName;
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
                buletinObj[j].GetComponent<PhoC>().schimbPoze(folderName, subfolderName, rootFileName,i) ;
                for (int n = 0; n < numarSchimbariPePoza; n++)
                {             
                    buletinObj[j].GetComponent<Randomizer>().schimbPozitie();
                    cameraObj[j].GetComponent<Randomizer>().schimbPozitie();
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                    cameraObj[j].GetComponent<Snapshot>().takeSnapshot(i,n);
=======
                    cameraObj[j].GetComponent<Snapshot>().takeSnapshot(rootFileName,i,j,n);
>>>>>>> Stashed changes
=======
                    cameraObj[j].GetComponent<Snapshot>().takeSnapshot(rootFileName,i,j,n);
>>>>>>> Stashed changes
                    Vector3 eulerRotation = new Vector3(m, -40, sun.transform.eulerAngles.z);
                    sun.transform.rotation = Quaternion.Euler(eulerRotation);
                     m += 80;
                    yield return new WaitForSeconds(0.5f);         
                }
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
