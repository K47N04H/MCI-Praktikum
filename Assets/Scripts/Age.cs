using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Age : MonoBehaviour
{
    public GameObject femaleFitYoung;
    public GameObject femaleSlimYoung;
    public GameObject femaleChubbyYoung;
    public GameObject femaleFitOld;
    public GameObject femaleSlimOld;
    public GameObject femaleChubbyOld;

    

    public void ChangeAgeForward()
    {
        if(femaleSlimYoung.activeInHierarchy == true)
        {

                femaleFitOld.SetActive(false);
                femaleSlimOld.SetActive(true);
                femaleChubbyOld.SetActive(false);
                femaleSlimYoung.SetActive(false);



        }

        else if(femaleChubbyYoung.activeInHierarchy == true)
        {
                femaleFitOld.SetActive(false);
                femaleSlimOld.SetActive(false);
                femaleChubbyOld.SetActive(true);
                femaleChubbyYoung.SetActive(false);


        }

        else if (femaleFitYoung.activeInHierarchy == true)
        {

                femaleFitOld.SetActive(true);
                femaleSlimOld.SetActive(false);
                femaleChubbyOld.SetActive(false);
                femaleFitYoung.SetActive(false);

        }

    }

    public void ChangeAgeBack()
    {
        if (femaleSlimOld.activeInHierarchy == true)
        {

            femaleFitOld.SetActive(false);
            femaleSlimYoung.SetActive(true);
            femaleChubbyOld.SetActive(false);
            femaleSlimOld.SetActive(false);



        }

        else if (femaleChubbyOld.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyYoung.SetActive(true);
            femaleChubbyOld.SetActive(false);


        }

        else if (femaleFitOld.activeInHierarchy == true)
        {

            femaleFitYoung.SetActive(true);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitOld.SetActive(false);

        }

    }
}
