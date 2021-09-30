using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Genderchange : MonoBehaviour
{
    public TMPro.TMP_Text textCategorie;
    public GameObject femaleFitYoung;
    public GameObject femaleSlimYoung;
    public GameObject femaleChubbyYoung;
    public GameObject femaleFitOld;
    public GameObject femaleSlimOld;
    public GameObject femaleChubbyOld;
    public GameObject maleFitYoung;
    public GameObject maleSlimYoung;
    public GameObject maleChubbyYoung;
    public GameObject maleFitOld;
    public GameObject maleSlimOld;
    public GameObject maleChubbyOld;

    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Bodytype";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Gender";
    }

    public void ChangeGender()
    {

        if (femaleSlimYoung.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(true);
            maleChubbyYoung.SetActive(false);
        }

        else if (femaleChubbyYoung.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(true);
        }

        else if (femaleFitYoung.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(true);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(false);
        }

        else if (maleFitYoung.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(true);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(false);
        }

        else if (maleSlimYoung.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(true);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(false);
        }

        else if (maleChubbyYoung.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(true);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(false);
        }

        else if (femaleSlimOld.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(true);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(false);
        }

        else if (femaleChubbyOld.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(true);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(false);
        }

        else if (femaleFitOld.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(true);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(false);
        }

        else if (maleFitOld.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(true);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(false);
        }

        else if (maleSlimOld.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(true);
            femaleChubbyOld.SetActive(false);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(false);
        }

        else if (maleChubbyOld.activeInHierarchy == true)
        {
            femaleFitOld.SetActive(false);
            femaleSlimOld.SetActive(false);
            femaleChubbyOld.SetActive(true);
            femaleFitYoung.SetActive(false);
            femaleSlimYoung.SetActive(false);
            femaleChubbyYoung.SetActive(false);
            maleFitOld.SetActive(false);
            maleSlimOld.SetActive(false);
            maleChubbyOld.SetActive(false);
            maleFitYoung.SetActive(false);
            maleSlimYoung.SetActive(false);
            maleChubbyYoung.SetActive(false);
        }

    }
}
