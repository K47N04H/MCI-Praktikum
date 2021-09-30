using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeCategorie : MonoBehaviour
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
    public GameObject femaleFitYoungCategory;
    public GameObject femaleSlimYoungCategory;
    public GameObject femaleChubbyYoungCategory;
    public GameObject femaleFitOldCategory;
    public GameObject femaleSlimOldCategory;
    public GameObject femaleChubbyOldCategory;
    public GameObject maleFitYoungCategory;
    public GameObject maleSlimYoungCategory;
    public GameObject maleChubbyYoungCategory;
    public GameObject maleFitOldCategory;
    public GameObject maleSlimOldCategory;
    public GameObject maleChubbyOldCategory;

    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Bodytype";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Gender";
    }

    public void ChangeAvatar()
    {

        if (femaleSlimYoung.activeInHierarchy == true)
        {
            femaleSlimYoungCategory.SetActive(true);
        }

        else if (femaleChubbyYoung.activeInHierarchy == true)
        {
            femaleChubbyYoungCategory.SetActive(true);
        }

        else if (femaleFitYoung.activeInHierarchy == true)
        {
            femaleFitYoungCategory.SetActive(true);
        }

        else if (maleFitYoung.activeInHierarchy == true)
        {
            maleFitYoungCategory.SetActive(true);
        }

        else if (maleSlimYoung.activeInHierarchy == true)
        {
            maleSlimYoungCategory.SetActive(true);
        }

        else if (maleChubbyYoung.activeInHierarchy == true)
        {
            maleChubbyYoungCategory.SetActive(true);
        }

        else if (femaleSlimOld.activeInHierarchy == true)
        {
            femaleSlimOldCategory.SetActive(true);
        }

        else if (femaleChubbyOld.activeInHierarchy == true)
        {
            femaleChubbyOldCategory.SetActive(true);
        }

        else if (femaleFitOld.activeInHierarchy == true)
        {
            femaleFitOldCategory.SetActive(true);
        }

        else if (maleFitOld.activeInHierarchy == true)
        {
            maleFitOldCategory.SetActive(true);
        }

        else if (maleSlimOld.activeInHierarchy == true)
        {
            maleSlimOldCategory.SetActive(true);
        }

        else if (maleChubbyOld.activeInHierarchy == true)
        {
            maleChubbyOldCategory.SetActive(true);
        }
    }
}