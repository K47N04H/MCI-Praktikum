using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bodytype : MonoBehaviour
{
    public TMPro.TMP_Text textCategorie;
    public GameObject femaleFit;
    public GameObject femaleSlim;
    public GameObject femaleChubby;
    public GameObject maleFit;
    public GameObject maleSlim;
    public GameObject maleChubby;

    private int numberBodytype = 0;

    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Age";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Gender";
    }


    public void ChangeBodytypeForward()
    {
        if (femaleFit.activeInHierarchy == true || femaleSlim.activeInHierarchy == true || femaleChubby.activeInHierarchy == true)
        {

            if (numberBodytype == 0)
            {
                femaleFit.SetActive(false);
                femaleSlim.SetActive(true);
                femaleChubby.SetActive(false);

                numberBodytype += 1;
            }

            else if (numberBodytype == 1)
            {
                femaleFit.SetActive(false);
                femaleSlim.SetActive(false);
                femaleChubby.SetActive(true);

                numberBodytype += 1;
            }

            else if (numberBodytype == 2)
            {
                femaleFit.SetActive(true);
                femaleSlim.SetActive(false);
                femaleChubby.SetActive(false);

                numberBodytype = 0;
            }
        }

        else if (maleFit.activeInHierarchy == true || maleSlim.activeInHierarchy == true || maleChubby.activeInHierarchy == true)
        {

            if (numberBodytype == 0)
            {
                maleFit.SetActive(false);
                maleSlim.SetActive(true);
                maleChubby.SetActive(false);

                numberBodytype += 1;
            }

            else if (numberBodytype == 1)
            {
                maleFit.SetActive(false);
                maleSlim.SetActive(false);
                maleChubby.SetActive(true);

                numberBodytype += 1;
            }

            else if (numberBodytype == 2)
            {
                maleFit.SetActive(true);
                maleSlim.SetActive(false);
                maleChubby.SetActive(false);

                numberBodytype = 0;
            }
        }

    }

    public void ChangeBodytypeBack()
    {
        if (femaleFit.activeInHierarchy == true || femaleSlim.activeInHierarchy == true || femaleChubby.activeInHierarchy == true)
        {
            if (numberBodytype == 0)
            {
                femaleFit.SetActive(false);
                femaleSlim.SetActive(false);
                femaleChubby.SetActive(true);

                numberBodytype += 1;
            }

            else if (numberBodytype == 1)
            {
                femaleFit.SetActive(false);
                femaleSlim.SetActive(true);
                femaleChubby.SetActive(false);

                numberBodytype += 1;
            }

            else if (numberBodytype == 2)
            {
                femaleFit.SetActive(true);
                femaleSlim.SetActive(false);
                femaleChubby.SetActive(false);

                numberBodytype = 0;
            }
        }

        if (maleFit.activeInHierarchy == true || maleSlim.activeInHierarchy == true || maleChubby.activeInHierarchy == true)
        {
            if (numberBodytype == 0)
            {
                maleFit.SetActive(false);
                maleSlim.SetActive(false);
                maleChubby.SetActive(true);

                numberBodytype += 1;
            }

            else if (numberBodytype == 1)
            {
                maleFit.SetActive(false);
                maleSlim.SetActive(true);
                maleChubby.SetActive(false);

                numberBodytype += 1;
            }

            else if (numberBodytype == 2)
            {
                maleFit.SetActive(true);
                maleSlim.SetActive(false);
                maleChubby.SetActive(false);

                numberBodytype = 0;
            }
        }
    }

}