using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Haircolor : MonoBehaviour
{

    Color[] haircolor =
    {
        new Color(1, 1f, 1f, 1f),
        new Color(0.5943396f, 0.1319459f, 0.1037291f, 1f),
        new Color(0.07266822f, 0.6698113f, 0.1575639f, 1),
        new Color(0.0745098f, 0.1679017f, 0.6705883f, 1f),
        new Color(0.8207547f, 0.1587308f, 0.5216417f, 1f)
     };

    public TMPro.TMP_Text textCategorie;
    public Color colorCategorie;
    public Renderer femaleA7;
    public Renderer femaleBabyBangs;
    public Renderer femaleLongHigh;
    public Renderer femalePonytailBack;
    public Renderer femalePonytailL;
    public Renderer femalePonytailR;
    public Renderer femaleDoubleLow;
    public Renderer femaleMessyHigh;
    public Renderer femaleMessyPonytailBack;
    public Renderer femaleSamuraiBun;
    public Renderer femaleSideBangs;
    public Renderer femaleSideBangsO;
    public Renderer femaleSpaceBun;
    public Renderer femaleStraightShortLow;

    private int numberHaircolor = 0;


    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Hairstyle";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Skincolor";
    }

    // Change categorie forward while clicking the right button
    public void ChangeSettingHaircolorForward()
    {

        if (numberHaircolor == 0)
        {
            femaleA7.material.color = haircolor[1];
            femaleBabyBangs.material.color = haircolor[1];
            femaleLongHigh.material.color = haircolor[1];
            femalePonytailBack.material.color = haircolor[1];
            femalePonytailL.material.color = haircolor[1];
            femalePonytailR.material.color = haircolor[1];
            femaleDoubleLow.material.color = haircolor[1];
            femaleMessyHigh.material.color = haircolor[1];
            femaleMessyPonytailBack.material.color = haircolor[1];
            femaleSamuraiBun.material.color = haircolor[1];
            femaleSideBangs.material.color = haircolor[1];
            femaleSideBangsO.material.color = haircolor[1];
            femaleSpaceBun.material.color = haircolor[1];
            femaleStraightShortLow.material.color = haircolor[1];

            numberHaircolor = 1;

        }
        else if (numberHaircolor == 1)
        {
            femaleA7.material.color = haircolor[2];
            femaleBabyBangs.material.color = haircolor[2];
            femaleLongHigh.material.color = haircolor[2];
            femalePonytailBack.material.color = haircolor[2];
            femalePonytailL.material.color = haircolor[2];
            femalePonytailR.material.color = haircolor[2];
            femaleDoubleLow.material.color = haircolor[2];
            femaleMessyHigh.material.color = haircolor[2];
            femaleMessyPonytailBack.material.color = haircolor[2];
            femaleSamuraiBun.material.color = haircolor[2];
            femaleSideBangs.material.color = haircolor[2];
            femaleSideBangsO.material.color = haircolor[2];
            femaleSpaceBun.material.color = haircolor[2];
            femaleStraightShortLow.material.color = haircolor[2];

            numberHaircolor = 2;
        }
        else if (numberHaircolor == 2)
        {
            femaleA7.material.color = haircolor[3];
            femaleBabyBangs.material.color = haircolor[3];
            femaleLongHigh.material.color = haircolor[3];
            femalePonytailBack.material.color = haircolor[3];
            femalePonytailL.material.color = haircolor[3];
            femalePonytailR.material.color = haircolor[3];
            femaleDoubleLow.material.color = haircolor[3];
            femaleMessyHigh.material.color = haircolor[3];
            femaleMessyPonytailBack.material.color = haircolor[3];
            femaleSamuraiBun.material.color = haircolor[3];
            femaleSideBangs.material.color = haircolor[3];
            femaleSideBangsO.material.color = haircolor[3];
            femaleSpaceBun.material.color = haircolor[3];
            femaleStraightShortLow.material.color = haircolor[3];

            numberHaircolor = 3;
        }

        else if (numberHaircolor == 3)
        {
            femaleA7.material.color = haircolor[4];
            femaleBabyBangs.material.color = haircolor[4];
            femaleLongHigh.material.color = haircolor[4];
            femalePonytailBack.material.color = haircolor[4];
            femalePonytailL.material.color = haircolor[4];
            femalePonytailR.material.color = haircolor[4];
            femaleDoubleLow.material.color = haircolor[4];
            femaleMessyHigh.material.color = haircolor[4];
            femaleMessyPonytailBack.material.color = haircolor[4];
            femaleSamuraiBun.material.color = haircolor[4];
            femaleSideBangs.material.color = haircolor[4];
            femaleSideBangsO.material.color = haircolor[4];
            femaleSpaceBun.material.color = haircolor[4];
            femaleStraightShortLow.material.color = haircolor[4];

            numberHaircolor = 4;
        }

        else if (numberHaircolor == 4)
        {
            femaleA7.material.color = haircolor[0];
            femaleBabyBangs.material.color = haircolor[0];
            femaleLongHigh.material.color = haircolor[0];
            femalePonytailBack.material.color = haircolor[0];
            femalePonytailL.material.color = haircolor[0];
            femalePonytailR.material.color = haircolor[0];
            femaleDoubleLow.material.color = haircolor[0];
            femaleMessyHigh.material.color = haircolor[0];
            femaleMessyPonytailBack.material.color = haircolor[0];
            femaleSamuraiBun.material.color = haircolor[0];
            femaleSideBangs.material.color = haircolor[0];
            femaleSideBangsO.material.color = haircolor[0];
            femaleSpaceBun.material.color = haircolor[0];
            femaleStraightShortLow.material.color = haircolor[0];

            numberHaircolor = 0;
        }
    }

    public void ChangeSettingHaircolorBack()
    {
        if (numberHaircolor == 0)
        {
            femaleA7.material.color = haircolor[4];
            femaleBabyBangs.material.color = haircolor[4];
            femaleLongHigh.material.color = haircolor[4];
            femalePonytailBack.material.color = haircolor[4];
            femalePonytailL.material.color = haircolor[4];
            femalePonytailR.material.color = haircolor[4];
            femaleDoubleLow.material.color = haircolor[4];
            femaleMessyHigh.material.color = haircolor[4];
            femaleMessyPonytailBack.material.color = haircolor[4];
            femaleSamuraiBun.material.color = haircolor[4];
            femaleSideBangs.material.color = haircolor[4];
            femaleSideBangsO.material.color = haircolor[4];
            femaleSpaceBun.material.color = haircolor[4];
            femaleStraightShortLow.material.color = haircolor[4];

            numberHaircolor = 4;
        }

        else if (numberHaircolor == 1)
        {
            femaleA7.material.color = haircolor[0];
            femaleBabyBangs.material.color = haircolor[0];
            femaleLongHigh.material.color = haircolor[0];
            femalePonytailBack.material.color = haircolor[0];
            femalePonytailL.material.color = haircolor[0];
            femalePonytailR.material.color = haircolor[0];
            femaleDoubleLow.material.color = haircolor[0];
            femaleMessyHigh.material.color = haircolor[0];
            femaleMessyPonytailBack.material.color = haircolor[0];
            femaleSamuraiBun.material.color = haircolor[0];
            femaleSideBangs.material.color = haircolor[0];
            femaleSideBangsO.material.color = haircolor[0];
            femaleSpaceBun.material.color = haircolor[0];
            femaleStraightShortLow.material.color = haircolor[0];

            numberHaircolor = 0;
        }

        else if (numberHaircolor == 2)
        {
            femaleA7.material.color = haircolor[1];
            femaleBabyBangs.material.color = haircolor[1];
            femaleLongHigh.material.color = haircolor[1];
            femalePonytailBack.material.color = haircolor[1];
            femalePonytailL.material.color = haircolor[1];
            femalePonytailR.material.color = haircolor[1];
            femaleDoubleLow.material.color = haircolor[1];
            femaleMessyHigh.material.color = haircolor[1];
            femaleMessyPonytailBack.material.color = haircolor[1];
            femaleSamuraiBun.material.color = haircolor[1];
            femaleSideBangs.material.color = haircolor[1];
            femaleSideBangsO.material.color = haircolor[1];
            femaleSpaceBun.material.color = haircolor[1];
            femaleStraightShortLow.material.color = haircolor[1];

            numberHaircolor = 1;


        }
        else if (numberHaircolor == 3)
        {
            femaleA7.material.color = haircolor[2];
            femaleBabyBangs.material.color = haircolor[2];
            femaleLongHigh.material.color = haircolor[2];
            femalePonytailBack.material.color = haircolor[2];
            femalePonytailL.material.color = haircolor[2];
            femalePonytailR.material.color = haircolor[2];
            femaleDoubleLow.material.color = haircolor[2];
            femaleMessyHigh.material.color = haircolor[2];
            femaleMessyPonytailBack.material.color = haircolor[2];
            femaleSamuraiBun.material.color = haircolor[2];
            femaleSideBangs.material.color = haircolor[2];
            femaleSideBangsO.material.color = haircolor[2];
            femaleSpaceBun.material.color = haircolor[2];
            femaleStraightShortLow.material.color = haircolor[2];

            numberHaircolor = 2;
        }

        else if (numberHaircolor == 4)
        {
            femaleA7.material.color = haircolor[3];
            femaleBabyBangs.material.color = haircolor[3];
            femaleLongHigh.material.color = haircolor[3];
            femalePonytailBack.material.color = haircolor[3];
            femalePonytailL.material.color = haircolor[3];
            femalePonytailR.material.color = haircolor[3];
            femaleDoubleLow.material.color = haircolor[3];
            femaleMessyHigh.material.color = haircolor[3];
            femaleMessyPonytailBack.material.color = haircolor[3];
            femaleSamuraiBun.material.color = haircolor[3];
            femaleSideBangs.material.color = haircolor[3];
            femaleSideBangsO.material.color = haircolor[3];
            femaleSpaceBun.material.color = haircolor[3];
            femaleStraightShortLow.material.color = haircolor[3];

            numberHaircolor = 3;
        }
    }

}
