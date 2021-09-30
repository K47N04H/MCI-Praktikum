using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Genderchange : MonoBehaviour
{
    public TMPro.TMP_Text textCategorie;
    public GameObject femaleFit;
    public GameObject femaleSlim;
    public GameObject femaleChubby;
    public GameObject maleFit;
    public GameObject maleSlim;
    public GameObject maleChubby;

    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Bodytype";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Gender";
    }

    public void ChangeGenderForward()
    {

        if (femaleFit.activeInHierarchy == true)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(false);
            maleFit.SetActive(true);
            maleSlim.SetActive(false);
            maleChubby.SetActive(false);
        }

        else if (femaleSlim.activeInHierarchy == true)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(false);
            maleFit.SetActive(false);
            maleSlim.SetActive(true);
            maleChubby.SetActive(false);
        }

        else if (femaleChubby.activeInHierarchy == true)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(false);
            maleFit.SetActive(false);
            maleSlim.SetActive(false);
            maleChubby.SetActive(true);
        }

        else if (maleFit.activeInHierarchy == true)
        {
            femaleFit.SetActive(true);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(false);
            maleFit.SetActive(false);
            maleSlim.SetActive(false);
            maleChubby.SetActive(false);
        }

        else if (maleSlim.activeInHierarchy == true)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(true);
            femaleChubby.SetActive(false);
            maleFit.SetActive(false);
            maleSlim.SetActive(false);
            maleChubby.SetActive(false);
        }

        else if (maleChubby.activeInHierarchy == true)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(true);
            maleFit.SetActive(false);
            maleSlim.SetActive(false);
            maleChubby.SetActive(false);
        }

    }

    public void ChangeGenderBack()
    {
        if (femaleFit.activeInHierarchy == true)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(false);
            maleFit.SetActive(true);
            maleSlim.SetActive(false);
            maleChubby.SetActive(false);
        }

        else if (femaleSlim.activeInHierarchy == true)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(false);
            maleFit.SetActive(false);
            maleSlim.SetActive(true);
            maleChubby.SetActive(false);
        }

        else if (femaleChubby.activeInHierarchy == true)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(false);
            maleFit.SetActive(false);
            maleSlim.SetActive(false);
            maleChubby.SetActive(true);
        }

        else if (maleFit.activeInHierarchy == true)
        {
            femaleFit.SetActive(true);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(false);
            maleFit.SetActive(false);
            maleSlim.SetActive(false);
            maleChubby.SetActive(false);
        }

        else if (maleSlim.activeInHierarchy == true)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(true);
            femaleChubby.SetActive(false);
            maleFit.SetActive(false);
            maleSlim.SetActive(false);
            maleChubby.SetActive(false);
        }

        else if (maleChubby.activeInHierarchy == true)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(true);
            maleFit.SetActive(false);
            maleSlim.SetActive(false);
            maleChubby.SetActive(false);
        }
    }
}
