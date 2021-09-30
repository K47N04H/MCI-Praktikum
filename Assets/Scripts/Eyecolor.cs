using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Eyecolor : MonoBehaviour
{
    Color[] eyecolor =
    {
        new Color(1f, 1f, 1f, 1f),
        new Color(0.5943396f, 0.1319459f, 0.1037291f, 1f),
        new Color(0.07266822f, 0.6698113f, 0.1575639f, 1),
        new Color(0.0745098f, 0.1679017f, 0.6705883f, 1f),
    };

    public TMPro.TMP_Text textCategorie;
    public Renderer femaleBaseEye;
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
    private int numberEyecolor = 0;

    public void ChangeCategoryTextForward()
    {

        if (femaleFitYoung.activeInHierarchy == true || femaleSlimYoung.activeInHierarchy == true || femaleChubbyYoung.activeInHierarchy == true || femaleFitOld.activeInHierarchy == true || femaleSlimOld.activeInHierarchy == true || femaleChubbyOld.activeInHierarchy == true)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = "Clothes top";
        }
        else if (maleFitYoung.activeInHierarchy == true || maleSlimYoung.activeInHierarchy == true || maleChubbyYoung.activeInHierarchy == true || maleFitOld.activeInHierarchy == true || maleSlimOld.activeInHierarchy == true || maleChubbyOld.activeInHierarchy == true)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = "Beard";
        }
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Hairstyle";
    }

    public void ChangeSettingEyecolorForward()
    {
        if (numberEyecolor == 0)
        {
            femaleBaseEye.materials[0].color = eyecolor[1];
            femaleBaseEye.materials[1].color = eyecolor[1];
            femaleBaseEye.materials[2].color = eyecolor[1];
            femaleBaseEye.materials[3].color = eyecolor[1];
            numberEyecolor += 1;
        }

        else if (numberEyecolor == 1)
        {
            femaleBaseEye.materials[0].color = eyecolor[2];
            femaleBaseEye.materials[1].color = eyecolor[2];
            femaleBaseEye.materials[2].color = eyecolor[2];
            femaleBaseEye.materials[3].color = eyecolor[2];
            numberEyecolor += 1;
        }

        else if (numberEyecolor == 2)
        {
            femaleBaseEye.materials[0].color = eyecolor[3];
            femaleBaseEye.materials[1].color = eyecolor[3];
            femaleBaseEye.materials[2].color = eyecolor[3];
            femaleBaseEye.materials[3].color = eyecolor[3];
            numberEyecolor += 1;
        }

        else if (numberEyecolor == 3)
        {
            femaleBaseEye.materials[0].color = eyecolor[0];
            femaleBaseEye.materials[1].color = eyecolor[0];
            femaleBaseEye.materials[2].color = eyecolor[0];
            femaleBaseEye.materials[3].color = eyecolor[0];
            numberEyecolor = 0;
        }
    }
}
