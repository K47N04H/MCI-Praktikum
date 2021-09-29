using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Haircolor : MonoBehaviour
{

    Color[] haircolor = 
    { 
        new Color(0.1792453f, 0.06442863f, 0.05157529f, 1f), 
        new Color(0.5943396f, 0.1319459f, 0.1037291f, 1f), 
        new Color(0.07266822f, 0.6698113f, 0.1575639f, 1),
        new Color(0.0745098f, 0.1679017f, 0.6705883f, 1f),
        new Color(0.8207547f, 0.1587308f, 0.5216417f, 1f)
     };

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


    // Change categorie forward while clicking the right button
    public void ChangeSettingHaircolorForward()
    {
            femaleA7.material.color = haircolor[numberHaircolor];
            femaleBabyBangs.material.color = haircolor[numberHaircolor];
            femaleLongHigh.material.color = haircolor[numberHaircolor];
            femalePonytailBack.material.color = haircolor[numberHaircolor];
            femalePonytailL.material.color = haircolor[numberHaircolor];
            femalePonytailR.material.color = haircolor[numberHaircolor];
            femaleDoubleLow.material.color = haircolor[numberHaircolor];
            femaleMessyHigh.material.color = haircolor[numberHaircolor];
            femaleMessyPonytailBack.material.color = haircolor[numberHaircolor];
            femaleSamuraiBun.material.color = haircolor[numberHaircolor];
            femaleSideBangs.material.color = haircolor[numberHaircolor];
            femaleSideBangsO.material.color = haircolor[numberHaircolor];
            femaleSpaceBun.material.color = haircolor[numberHaircolor];
            femaleStraightShortLow.material.color = haircolor[numberHaircolor];
        if(numberHaircolor == haircolor.Length)
        {
            numberHaircolor -= 1;
        }
        else
        {
            numberHaircolor += 1;
        }

    }

    public void ChangeSettingHaircolorBack()
    {
        femaleA7.material.color = haircolor[numberHaircolor];
        femaleBabyBangs.material.color = haircolor[numberHaircolor];
        femaleLongHigh.material.color = haircolor[numberHaircolor];
        femalePonytailBack.material.color = haircolor[numberHaircolor];
        femalePonytailL.material.color = haircolor[numberHaircolor];
        femalePonytailR.material.color = haircolor[numberHaircolor];
        femaleDoubleLow.material.color = haircolor[numberHaircolor];
        femaleMessyHigh.material.color = haircolor[numberHaircolor];
        femaleMessyPonytailBack.material.color = haircolor[numberHaircolor];
        femaleSamuraiBun.material.color = haircolor[numberHaircolor];
        femaleSideBangs.material.color = haircolor[numberHaircolor];
        femaleSideBangsO.material.color = haircolor[numberHaircolor];
        femaleSpaceBun.material.color = haircolor[numberHaircolor];
        femaleStraightShortLow.material.color = haircolor[numberHaircolor];
        if (numberHaircolor == 0)
        {
            numberHaircolor += 1;
        }
        else
        {
            numberHaircolor -= 1;
        }
    }

}
